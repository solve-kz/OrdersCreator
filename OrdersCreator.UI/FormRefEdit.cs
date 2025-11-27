using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    public partial class FormRefEdit : Form
    {
        private readonly ICustomerService _customerService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        private readonly BindingSource _customersBinding = new();
        private readonly BindingSource _categoriesBinding = new();
        private readonly BindingSource _productsBinding = new();

        private Customer? _currentCustomer;
        private Category? _currentCategory;
        private Product? _currentProduct;
        private bool _isNewCustomer;
        private bool _isNewCategory;
        private bool _isNewProduct;

        public FormRefEdit(ICustomerService customerService, ICategoryService categoryService, IProductService productService)
        {
            _customerService = customerService;
            _categoryService = categoryService;
            _productService = productService;

            InitializeComponent();

            InitCustomersTab();
            InitCategoriesTab();
            InitProductsTab();
        }

        private void InitCustomersTab()
        {
            // если колонки в DataGridView уже заданы в дизайнере –
            // сделай AutoGenerateColumns = false
            dataGridViewCustomers.AutoGenerateColumns = false;

            // если нет – можно временно включить авто-генерацию:
            // dataGridViewCustomers.AutoGenerateColumns = true;

            dataGridViewCustomers.ReadOnly = true;
            dataGridViewCustomers.MultiSelect = false;
            dataGridViewCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewCustomers.DataSource = _customersBinding;
            dataGridViewCustomers.SelectionChanged += DataGridViewCustomers_SelectionChanged;
            dataGridViewCustomers.RowPostPaint += DataGridViewCustomers_RowPostPaint;

            btnCustomerAdd.Click += BtnAddCustomer_Click;
            btnCustomerSave.Click += BtnSaveCustomer_Click;
            btnCustomerDel.Click += BtnDeleteCustomer_Click;
            btnCustomerCancel.Click += BtnCancelCustomer_Click;

            btnCustomersImport.Click += BtnImportCustomersXlsx_Click;
            btnCustomersExport.Click += BtnExportCustomersXlsx_Click;

            LoadCustomers();
        }

        private void InitCategoriesTab()
        {

            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.MultiSelect = false;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewCategories.DataSource = _categoriesBinding;
            dataGridViewCategories.SelectionChanged += DataGridViewCategories_SelectionChanged;
            dataGridViewCategories.RowPostPaint += DataGridViewCategories_RowPostPaint;

            btnCategoryAdd.Click += BtnAddCategory_Click;
            btnCategorySave.Click += BtnSaveCategory_Click;
            btnCategoryDel.Click += BtnDeleteCategory_Click;
            btnCategoryCancel.Click += BtnCancelCategory_Click;
           
            LoadCategories();
        }

        private void InitProductsTab()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.MultiSelect = false;

            // привязка столбцов к свойствам модели Product
            ProductNumber.DataPropertyName = "RowNumber";
            ProductCategory.DataPropertyName = "CategoryName";
            ProductTitle.DataPropertyName = "ProductName";
            ProductCode.DataPropertyName = "ProductCode";

            dataGridViewProducts.DataSource = _productsBinding;
            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
            dataGridViewProducts.RowPostPaint += DataGridViewProducts_RowPostPaint;

            btnProductAdd.Click += BtnProductAdd_Click;
            btnProductSave.Click += BtnProductSave_Click;
            btnProductDel.Click += BtnProductDelete_Click;
            btnProductCancel.Click += BtnProductCancel_Click;

            btnFilterApply.Click += BtnProductFilterApply_Click;
            btnFilterCancel.Click += BtnProductFilterReset_Click;

            btnProductsImport.Click += BtnProductsImport_Click;
            btnProductsExport.Click += BtnProductsExport_Click;

            LoadCategoriesForProductCombos();
            LoadProducts();
        }

        private void LoadCustomers(int? selectId = null)
        {
            var customers = _customerService
                .GetAll()
                .OrderBy(c => c.Name)
                .ToList();

            _customersBinding.DataSource = customers;
            CustomerTitle.DataPropertyName = nameof(Customer.Name);

            // попытаться выделить строку с нужным Id (после добавления/сохранения)
            if (selectId.HasValue)
            {
                var index = customers.FindIndex(c => c.Id == selectId.Value);
                if (index >= 0)
                {
                    dataGridViewCustomers.ClearSelection();
                    dataGridViewCustomers.Rows[index].Selected = true;
                    dataGridViewCustomers.CurrentCell = dataGridViewCustomers.Rows[index].Cells[0];
                }
            }

            UpdateCustomerEditorFromSelection();
        }

        private void LoadCategories(int? selectId = null)
        {
            var categories = _categoryService
                .GetAll()
                .OrderBy(c => c.Name)
                .ToList();

            _categoriesBinding.DataSource = categories;
            CategoryTitle.DataPropertyName = nameof(Category.Name);

            // попытаться выделить строку с нужным Id (после добавления/сохранения)
            if (selectId.HasValue)
            {
                var index = categories.FindIndex(c => c.Id == selectId.Value);
                if (index >= 0)
                {
                    dataGridViewCategories.ClearSelection();
                    dataGridViewCategories.Rows[index].Selected = true;
                    dataGridViewCategories.CurrentCell = dataGridViewCategories.Rows[index].Cells[0];
                }
            }

            UpdateCategoryEditorFromSelection();
        }

        private void LoadCategoriesForProductCombos()
        {
            var categories = _categoryService
                .GetAll()
                .OrderBy(c => c.Name)
                .ToList();


            // фильтр
            cmbProductCategoryFilter.DataSource = categories.ToList();
            cmbProductCategoryFilter.DisplayMember = nameof(Category.Name);
            cmbProductCategoryFilter.ValueMember = nameof(Category.Id);
            cmbProductCategoryFilter.SelectedIndex = -1;   // ничего не выбрано

            // редактор
            cmbProductCategory.DataSource = categories;
            cmbProductCategory.DisplayMember = nameof(Category.Name);
            cmbProductCategory.ValueMember = nameof(Category.Id);
            cmbProductCategory.SelectedIndex = -1;
        }

        private int? GetCurrentProductFilterCategoryId()
        {
            if (cmbProductCategoryFilter.SelectedItem is Category cat)
                return cat.Id;
            return null;
        }

        private void LoadProducts(int? categoryId = null, int? selectId = null)
        {
            IReadOnlyList<Product> products;

            if (categoryId.HasValue)
                products = _productService.GetByCategory(categoryId.Value);
            else
                products = _productService.GetAll();

            // проекция для отображения категории по имени
            var data = products
                .OrderBy(p => p.Name)
                .Select((p, idx) => new
                {
                    RowNumber = idx + 1,
                    CategoryName = p.Category?.Name ?? "",  // если Category не загружена, можно потом подтянуть по Id
                    ProductName = p.Name,
                    ProductCode = p.Code,
                    Product = p
                })
                .ToList();

            _productsBinding.DataSource = data;
            
            if (selectId.HasValue && products.Count > 0)
            {
                var index = products.ToList().FindIndex(p => p.Id == selectId.Value);
                if (index >= 0 && index < dataGridViewProducts.Rows.Count)
                {
                    dataGridViewProducts.ClearSelection();
                    dataGridViewProducts.Rows[index].Selected = true;
                    dataGridViewProducts.CurrentCell = dataGridViewProducts.Rows[index].Cells[0];
                }
            }

            UpdateProductEditorFromSelection();
        }


        private void DataGridViewCustomers_RowPostPaint(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = (DataGridView)sender!;

            // индекс нужной колонки, где написано "№"
            int numberColumnIndex = 0;

            var cellBounds = grid.GetCellDisplayRectangle(numberColumnIndex, e.RowIndex, false);

            string rowNumber = (e.RowIndex + 1).ToString();

            using (var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                e.Graphics.DrawString(
                    rowNumber,
                    grid.Font,
                    SystemBrushes.ControlText,
                    cellBounds,
                    centerFormat);
            }
        }

        private void DataGridViewCategories_RowPostPaint(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = (DataGridView)sender!;

            // индекс нужной колонки, где написано "№"
            int numberColumnIndex = 0;

            var cellBounds = grid.GetCellDisplayRectangle(numberColumnIndex, e.RowIndex, false);

            string rowNumber = (e.RowIndex + 1).ToString();

            using (var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
            {
                e.Graphics.DrawString(
                    rowNumber,
                    grid.Font,
                    SystemBrushes.ControlText,
                    cellBounds,
                    centerFormat);
            }
        }

        private void DataGridViewProducts_RowPostPaint(object? sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = (DataGridView)sender!;
            string rowNumber = (e.RowIndex + 1).ToString();

            var cellBounds = grid.GetCellDisplayRectangle(0, e.RowIndex, false);

            using var format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            e.Graphics.DrawString(
                rowNumber,
                grid.Font,
                SystemBrushes.ControlText,
                cellBounds,
                format);
        }

        private void DataGridViewCustomers_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isNewCustomer)
                return; // если в режиме добавления, не перезатираем ввод

            UpdateCustomerEditorFromSelection();
        }

        private void DataGridViewCategories_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isNewCategory)
                return; // если в режиме добавления, не перезатираем ввод

            UpdateCategoryEditorFromSelection();
        }

        private void DataGridViewProducts_SelectionChanged(object? sender, EventArgs e)
        {
            if (_isNewProduct)
                return;

            UpdateProductEditorFromSelection();
        }

        private void UpdateCustomerEditorFromSelection()
        {
            if (dataGridViewCustomers.CurrentRow?.DataBoundItem is Customer c)
            {
                _currentCustomer = c;
                _isNewCustomer = false;

                tbCustomerTitle.Text = c.Name;
            }
            else
            {
                _currentCustomer = null;
                _isNewCustomer = false;
                tbCustomerTitle.Text = string.Empty;
            }
        }

        private void UpdateCategoryEditorFromSelection()
        {
            if (dataGridViewCategories.CurrentRow?.DataBoundItem is Category c)
            {
                _currentCategory = c;
                _isNewCategory = false;

                tbCategoryTitle.Text = c.Name;
            }
            else
            {
                _currentCategory = null;
                _isNewCategory = false;
                tbCategoryTitle.Text = string.Empty;
            }
        }

        private void UpdateProductEditorFromSelection()
        {
            if (dataGridViewProducts.CurrentRow?.DataBoundItem is { } rowObj)
            {
                // rowObj – анонимный объект с полем Product
                var prop = rowObj.GetType().GetProperty("Product");
                _currentProduct = prop?.GetValue(rowObj) as Product;
            }
            else
            {
                _currentProduct = null;
            }

            if (_currentProduct != null)
            {
                _isNewProduct = false;
                tbProductCode.Text = _currentProduct.Code;
                tbProductTitle.Text = _currentProduct.Name;

                // выставить категорию в комбобоксе по Id
                if (_currentProduct.CategoryId != 0)
                {
                    for (int i = 0; i < cmbProductCategory.Items.Count; i++)
                    {
                        if (cmbProductCategory.Items[i] is Category c && c.Id == _currentProduct.CategoryId)
                        {
                            cmbProductCategory.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    cmbProductCategory.SelectedIndex = -1;
                }
            }
            else
            {
                _isNewProduct = false;
                tbProductCode.Text = "";
                tbProductTitle.Text = "";
                cmbProductCategory.SelectedIndex = -1;
            }
        }

        private void BtnAddCustomer_Click(object? sender, EventArgs e)
        {
            // режим добавления нового контрагента
            _currentCustomer = null;
            _isNewCustomer = true;
            tbCustomerTitle.Text = string.Empty;
            tbCustomerTitle.Focus();

            dataGridViewCustomers.ClearSelection();
        }

        private void BtnAddCategory_Click(object? sender, EventArgs e)
        {
            // режим добавления нового контрагента
            _currentCategory = null;
            _isNewCategory = true;
            tbCategoryTitle.Text = string.Empty;
            tbCategoryTitle.Focus();

            dataGridViewCategories.ClearSelection();
        }

        private void BtnProductAdd_Click(object? sender, EventArgs e)
        {
            _currentProduct = null;
            _isNewProduct = true;

            tbProductCode.Text = "";
            tbProductTitle.Text = "";
            cmbProductCategory.SelectedIndex = -1;

            tbProductCode.Focus();
        }

        private void BtnSaveCustomer_Click(object? sender, EventArgs e)
        {
            var name = tbCustomerTitle.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(this, "Введите наименование контрагента.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCustomerTitle.Focus();
                return;
            }

            try
            {
                if (_isNewCustomer || _currentCustomer == null || _currentCustomer.Id == 0)
                {
                    // создаём нового
                    var created = _customerService.AddCustomer(name);
                    _isNewCustomer = false;
                    _currentCustomer = created;

                    LoadCustomers(created.Id);
                }
                else
                {
                    // обновляем существующего
                    _currentCustomer.Name = name;
                    _customerService.UpdateCustomer(_currentCustomer);

                    LoadCustomers(_currentCustomer.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка сохранения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveCategory_Click(object? sender, EventArgs e)
        {
            var name = tbCategoryTitle.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(this, "Введите наименование категории.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCategoryTitle.Focus();
                return;
            }

            try
            {
                if (_isNewCategory || _currentCategory == null || _currentCategory.Id == 0)
                {
                    // создаём нового
                    var created = _categoryService.AddCategory(name);
                    _isNewCategory = false;
                    _currentCategory = created;

                    LoadCategories(created.Id);
                }
                else
                {
                    // обновляем существующего
                    _currentCategory.Name = name;
                    _categoryService.UpdateCategory(_currentCategory);

                    LoadCategories(_currentCategory.Id);
                }
                LoadCategoriesForProductCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка сохранения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProductSave_Click(object? sender, EventArgs e)
        {
            var code = tbProductCode.Text.Trim();
            var name = tbProductTitle.Text.Trim();
            var category = cmbProductCategory.SelectedItem as Category;

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show(this, "Введите код товара.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbProductCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(this, "Введите наименование товара.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbProductTitle.Focus();
                return;
            }

            if (category == null)
            {
                MessageBox.Show(this, "Выберите категорию товара.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProductCategory.DroppedDown = true;
                return;
            }

            try
            {
                if (_isNewProduct || _currentProduct == null || _currentProduct.Id == 0)
                {
                    var created = _productService.AddProduct(code, name, category);
                    _isNewProduct = false;
                    _currentProduct = created;
                    LoadProducts(category.Id, created.Id);
                }
                else
                {
                    _currentProduct.Code = code;
                    _currentProduct.Name = name;
                    _currentProduct.CategoryId = category.Id;
                    _currentProduct.Category = category;

                    _productService.UpdateProduct(_currentProduct);
                    
                }
                var filterCategoryId = GetCurrentProductFilterCategoryId();
                LoadProducts(filterCategoryId, _currentProduct.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка сохранения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteCustomer_Click(object? sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                MessageBox.Show(this, "Не выбран контрагент для удаления.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(this,
                $"Удалить контрагента \"{_currentCustomer.Name}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _customerService.DeleteCustomer(_currentCustomer.Id);
                _currentCustomer = null;
                _isNewCustomer = false;

                LoadCustomers(); // без selectId
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка удаления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteCategory_Click(object? sender, EventArgs e)
        {
            if (_currentCategory == null)
            {
                MessageBox.Show(this, "Не выбрана категория для удаления.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(this,
                $"Удалить категорию \"{_currentCategory.Name}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _categoryService.DeleteCategory(_currentCategory.Id);
                _currentCategory = null;
                _isNewCategory = false;

                LoadCategories(); // без selectId
                LoadCategoriesForProductCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка удаления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProductDelete_Click(object? sender, EventArgs e)
        {
            if (_currentProduct == null)
            {
                MessageBox.Show(this, "Не выбран товар для удаления.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(this,
                $"Удалить товар \"{_currentProduct.Name}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _productService.DeleteProduct(_currentProduct.Id);
                _currentProduct = null;
                _isNewProduct = false;
                LoadProducts(GetCurrentProductFilterCategoryId());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка удаления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void BtnCancelCustomer_Click(object? sender, EventArgs e)
        {
            _isNewCustomer = false;
            UpdateCustomerEditorFromSelection();
        }

        private void BtnCancelCategory_Click(object? sender, EventArgs e)
        {
            _isNewCategory = false;
            UpdateCategoryEditorFromSelection();
        }

        private void BtnProductCancel_Click(object? sender, EventArgs e)
        {
            _isNewProduct = false;
            UpdateProductEditorFromSelection();
        }

        private void BtnProductFilterApply_Click(object? sender, EventArgs e)
        {
            if (cmbProductCategoryFilter.SelectedItem is Category category)
            {
                LoadProducts(category.Id);
            }
            else
            {
                LoadProducts(null);
            }
        }

        private void BtnProductFilterReset_Click(object? sender, EventArgs e)
        {
            cmbProductCategoryFilter.SelectedIndex = -1;
            LoadProducts(null);
        }

        private void BtnImportCustomersXlsx_Click(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*",
                Title = "Импорт контрагентов"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                var imported = _customerService.ImportFromXlsx(dialog.FileName);
                LoadCustomers();

                MessageBox.Show(this,
                    $"Импортировано записей: {imported.Count}.",
                    "Импорт завершён",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка импорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void BtnProductsImport_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(this,
                "Здесь будет импорт товаров из .xlsx.",
                "Импорт .xlsx",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExportCustomersXlsx_Click(object? sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*",
                FileName = "customers.xlsx",
                Title = "Экспорт контрагентов"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                _customerService.ExportToXlsx(dialog.FileName);

                MessageBox.Show(this,
                    "Экспорт завершён успешно.",
                    "Экспорт .xlsx",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка экспорта", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void BtnProductsExport_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(this,
                "Здесь будет экспорт товаров в .xlsx.",
                "Экспорт .xlsx",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
