using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dollars
{
    public class DB
    {
        public static string ConnectionString { get; private set; } = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + @"\DollarsDB\DollarsDB.mdf;Integrated Security=True;Connect Timeout=30";

        public static StaffsDB StaffsDB { get; private set; } = new StaffsDB();
        public static PrdCategoriesDB PrdCategoriesDB { get; private set; } = new PrdCategoriesDB();
        public static CustomersDB CustomersDB { get; private set; } = new CustomersDB();
        public static ProductsDB ProductsDB { get; private set; } = new ProductsDB();
        public static StockInHistoryDB StockInHistoryDB { get; private set; } = new StockInHistoryDB();
        public static DiscountDB DiscountDB { get; private set; } = new DiscountDB();
        public static StoreInfoDB StoreInfoDB { get; private set; } = new StoreInfoDB();
        public static TransactionsDB TransactionsDB { get; private set; } = new TransactionsDB();

        public static void Validate()
        {
            StaffsDB.Validate();
            PrdCategoriesDB.Validate();
            CustomersDB.Validate();
            ProductsDB.Validate();
            StockInHistoryDB.Validate();
            DiscountDB.Validate();
            StoreInfoDB.Validate();
            TransactionsDB.Validate();
        }
    }

    public class TransactionsDB
    {
        public List<Transaction> Transactions { get; private set; }

        public void Validate()
        {
            Transactions = new List<Transaction>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM TransactionsTbl WHERE ParentAccountID='" + Account.Active.ParentAccountID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Transactions.Add(new Transaction
                    {
                        Number = Convert.ToInt32(reader["Number"]),
                        CashierID = Convert.ToInt32(reader["CashierID"]),
                        CashierName = reader["CashierName"].ToString(),
                        CustomerID = Convert.ToInt32(reader["CustomerID"]),
                        CustomerName = reader["CustomerName"].ToString(),
                        Date = Convert.ToDateTime(reader["Date"]),
                        Subtotal = Convert.ToDouble(reader["Subtotal"])
                    });
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Transactions\n[Info]: " + ex.Message, "TransactionsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Add(Transaction transaction)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "INSERT INTO TransactionsTbl(ParentAccountID, Number, CashierID, CashierName, CustomerID, CustomerName, Date, Subtotal) " +
                    "VALUES(@ParentAccountID, @Number, @CashierID, @CashierName, @CustomerID, @CustomerName, @Date, @Subtotal)";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", Account.Active.ParentAccountID);
                cmd.Parameters.AddWithValue("@Number", transaction.Number);
                cmd.Parameters.AddWithValue("@CashierID", transaction.CashierID);
                cmd.Parameters.AddWithValue("@CashierName", transaction.CashierName);
                cmd.Parameters.AddWithValue("@CustomerID", transaction.CustomerID);
                cmd.Parameters.AddWithValue("@CustomerName", transaction.CustomerName);
                cmd.Parameters.AddWithValue("@Date", transaction.Date);
                cmd.Parameters.AddWithValue("@Subtotal", transaction.Subtotal);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add Transaction\n[Info]: " + ex.Message, "TransactionsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Transaction Get(int number)
        {
            foreach (Transaction transaction in Transactions)
            {
                if (number == transaction.Number)
                    return transaction;
            }

            return new Transaction();
        }
    }

    public class StoreInfoDB
    {
        public void Validate()
        {
            StoreInfo.Active = Get();
        }

        public void Add(int parentAccID, StoreInfo storeInfo)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "INSERT INTO StoreInfoTbl(ParentAccountID, Name, Address, ContactNo, Email, VAT, TotalTransactions, TotalSales) " +
                    "VALUES(@ParentAccountID, @Name, @Address, @ContactNo, @Email, @VAT, @TotalTransactions, @TotalSales)";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", parentAccID);
                cmd.Parameters.AddWithValue("@Name", storeInfo.Name);
                cmd.Parameters.AddWithValue("@Address", storeInfo.Address);
                cmd.Parameters.AddWithValue("@ContactNo", storeInfo.ContactNo);
                cmd.Parameters.AddWithValue("@Email", storeInfo.Email);
                cmd.Parameters.AddWithValue("@VAT", storeInfo.Vat);
                cmd.Parameters.AddWithValue("@TotalTransactions", storeInfo.TotalTransactions);
                cmd.Parameters.AddWithValue("@TotalSales", storeInfo.TotalSales);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add Store Info\n[Info]: " + ex.Message, "StoreInfoTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Update(StoreInfo storeInfo)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "UPDATE StoreInfoTbl SET Name=@Name, Address=@Address, ContactNo=@ContactNo, Email=@Email, VAT=@VAT, " +
                    "TotalTransactions=@TotalTransactions, TotalSales=@TotalSales WHERE ParentAccountID=@ParentAccountID";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", Account.Active.ParentAccountID);
                cmd.Parameters.AddWithValue("@Name", storeInfo.Name);
                cmd.Parameters.AddWithValue("@Address", storeInfo.Address);
                cmd.Parameters.AddWithValue("@ContactNo", storeInfo.ContactNo);
                cmd.Parameters.AddWithValue("@Email", storeInfo.Email);
                cmd.Parameters.AddWithValue("@VAT", storeInfo.Vat);
                cmd.Parameters.AddWithValue("@TotalTransactions", storeInfo.TotalTransactions);
                cmd.Parameters.AddWithValue("@TotalSales", storeInfo.TotalSales);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update store info\n[Info]: " + ex.Message, "StoreInfoTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public StoreInfo Get()
        {
            StoreInfo res = new StoreInfo();
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM StoreInfoTbl WHERE ParentAccountID='" + Account.Active.ParentAccountID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    res = new StoreInfo
                    {
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        ContactNo = reader["ContactNo"].ToString(),
                        Email = reader["Email"].ToString(),
                        Vat = Convert.ToDouble(reader["VAT"]),
                        TotalTransactions = Convert.ToInt32(reader["TotalTransactions"]),
                        TotalSales = Convert.ToDouble(reader["TotalSales"])
                    };
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load store info\n[Info]: " + ex.Message, "StoreInfoTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return res;
        }
    }

    public class DiscountDB
    {
        public List<Discount> Discounts { get; private set; }

        public void Validate()
        {
            Discounts = new List<Discount>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM DiscountsTbl WHERE ParentAccountID='" + Account.Active.ParentAccountID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Discounts.Add(new Discount
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        DiscountType = (Discount.Type)Convert.ToInt32(reader["Type"]),
                        Value = Convert.ToDouble(reader["Value"]),
                        ApplyDiscountOn = (Discount.ApplyOn)Convert.ToInt32(reader["ApplyOn"]),
                        Min = Convert.ToDouble(reader["Min"]),
                        ApplyOnID = Convert.ToInt32(reader["ApplyOnID"]),
                        ApplyAutomatically = Convert.ToBoolean(reader["ApplyAutomatically"]),
                        StartDate = Convert.ToDateTime(reader["StartDate"]),
                        EndDate = Convert.ToDateTime(reader["EndDate"])
                    });
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load DiscountsTbl\n[Info]: " + ex.Message, "DiscountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Add(Discount discount)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "INSERT INTO DiscountsTbl(ParentAccountID, Name, Type, Value, ApplyOn, Min, ApplyOnID, ApplyAutomatically, StartDate, EndDate) " +
                    "VALUES(@ParentAccountID, @Name, @Type, @Value, @ApplyOn, @Min, @ApplyOnID, @ApplyAutomatically, @StartDate, @EndDate)";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", Account.Active.ParentAccountID);
                cmd.Parameters.AddWithValue("@Name", discount.Name);
                cmd.Parameters.AddWithValue("@Type", (int)discount.DiscountType);
                cmd.Parameters.AddWithValue("@Value", discount.Value);
                cmd.Parameters.AddWithValue("@ApplyOn", (int)discount.ApplyDiscountOn);
                cmd.Parameters.AddWithValue("@Min", discount.Min);
                cmd.Parameters.AddWithValue("@ApplyOnID", discount.ApplyOnID);
                cmd.Parameters.AddWithValue("@ApplyAutomatically", discount.ApplyAutomatically);
                cmd.Parameters.AddWithValue("@StartDate", discount.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", discount.EndDate);

                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show(discount.Name + " is registered", "Add Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add discount\n[Info]: " + ex.Message, "DiscountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Update(Discount discount)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "UPDATE DiscountsTbl SET Name=@Name, Type=@Type, Value=@Value, ApplyOn=@ApplyOn, Min=@Min, ApplyOnID=@ApplyOnID, " +
                    "ApplyAutomatically=@ApplyAutomatically, StartDate=@StartDate, EndDate=@EndDate WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@Id", discount.Id);
                cmd.Parameters.AddWithValue("@Name", discount.Name);
                cmd.Parameters.AddWithValue("@Type", (int)discount.DiscountType);
                cmd.Parameters.AddWithValue("@Value", discount.Value);
                cmd.Parameters.AddWithValue("@ApplyOn", (int)discount.ApplyDiscountOn);
                cmd.Parameters.AddWithValue("@Min", discount.Min);
                cmd.Parameters.AddWithValue("@ApplyOnID", discount.ApplyOnID);
                cmd.Parameters.AddWithValue("@ApplyAutomatically", discount.ApplyAutomatically);
                cmd.Parameters.AddWithValue("@StartDate", discount.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", discount.EndDate);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update discount\n[Info]: " + ex.Message, "DiscountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Discount Get(int id)
        {
            foreach (Discount discount in Discounts)
            {
                if (discount.Id == id)
                    return discount;
            }

            return new Discount();
        }

        public bool Exists(int id)
        {
            foreach (Discount discount in Discounts)
            {
                if (discount.Id == id)
                    return true;
            }

            return false;
        }

        public void Delete(int id)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "DELETE FROM DiscountsTbl WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show("Discount #'" + id + "' is deleted", "Delete Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete discount\n[Info]: " + ex.Message, "DiscountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void DeletingCategory(int catID)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "DELETE FROM DiscountsTbl WHERE ApplyOn='" + (int)Discount.ApplyOn.Category + "' AND ApplyOnID='" + catID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete discount\n[Info]: " + ex.Message, "DiscountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void DeletingProduct(int prdID)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "DELETE FROM DiscountsTbl WHERE ApplyOn='" + (int)Discount.ApplyOn.Product+ "' AND ApplyOnID='" + prdID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete discount\n[Info]: " + ex.Message, "DiscountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }

    public class StockInHistoryDB
    {
        public List<StockInInfo> StockInHistory { get; private set; }

        public void Validate()
        {
            StockInHistory = new List<StockInInfo>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM StockInHistoryTbl WHERE ParentAccountID='" + Account.Active.ParentAccountID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    StockInHistory.Add(new StockInInfo
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        ProductID = Convert.ToInt32(reader["ProductID"]),
                        ProductName = reader["ProductName"].ToString(),
                        ProductCategory = reader["ProductCategory"].ToString(),
                        Qty = Convert.ToInt32(reader["Quantity"]),
                        StockInDate = Convert.ToDateTime(reader["StockInDate"])
                    });
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load StockInHistoryTbl\n[Info]: " + ex.Message, "StockInHistoryTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Add(StockInInfo stockInInfo)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "INSERT INTO StockInHistoryTbl(ParentAccountID, ProductID, ProductName, ProductCategory, Quantity, StockInDate) VALUES(@ParentAccountID, @ProductID, @ProductName, @ProductCategory, @Quantity, @StockInDate)";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", Account.Active.ParentAccountID);
                cmd.Parameters.AddWithValue("@ProductID", stockInInfo.ProductID);
                cmd.Parameters.AddWithValue("@ProductName", stockInInfo.ProductName);
                cmd.Parameters.AddWithValue("@ProductCategory", stockInInfo.ProductCategory);
                cmd.Parameters.AddWithValue("@Quantity", stockInInfo.Qty);
                cmd.Parameters.AddWithValue("@StockInDate", stockInInfo.StockInDate);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add Stock in History\n[Info]: " + ex.Message, "StockInHistoryTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public StockInInfo Get(int id)
        {
            foreach (StockInInfo s in StockInHistory)
            {
                if (s.Id == id)
                    return s;
            }

            return new StockInInfo();
        }
    }

    public class ProductsDB
    {
        public List<Product> Products { get; private set; }

        public void Validate()
        {
            Products = new List<Product>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM ProductsTbl WHERE ParentAccountID='" + Account.Active.ParentAccountID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductCategory cat = DB.PrdCategoriesDB.Get(reader.GetInt32(3));

                    Products.Add(new Product
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Category = cat.Id > 0 ? cat : new ProductCategory(),
                        UnitPrice = Convert.ToDouble(reader["UnitPrice"]),
                        Qty = Convert.ToInt32(reader["Quantity"]),
                        Image = Utils.GetImage((byte[])reader["Image"])
                    });
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load ProductsTbl\n[Info]: " + ex.Message, "ProductsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Add(Product product)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "INSERT INTO ProductsTbl(ParentAccountID, Name, CategoryID, UnitPrice, Quantity, Image) VALUES(@ParentAccountID, @Name, @CategoryID, @UnitPrice, @Quantity, @Image)";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", Account.Active.ParentAccountID);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@CategoryID", product.Category.Id);
                cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                cmd.Parameters.AddWithValue("@Quantity", product.Qty);
                cmd.Parameters.AddWithValue("@Image", Utils.GetImageData(product.Image));

                /*using (MemoryStream ms = new MemoryStream())
                {
                    product.Image.Save(ms, product.Image.RawFormat);
                    cmd.Parameters.AddWithValue("@Image", ms.ToArray());
                }*/


                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show(product.Name + " is registered", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add product\n[Info]: " + ex.Message, "ProductsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Update(Product product)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "UPDATE ProductsTbl SET Name=@Name, CategoryID=@CategoryID, UnitPrice=@UnitPrice, Quantity=@Quantity, Image=@Image WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@CategoryID", product.Category.Id);
                cmd.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                cmd.Parameters.AddWithValue("@Quantity", product.Qty);
                cmd.Parameters.AddWithValue("@Image", Utils.GetImageData(product.Image));

                /*using (MemoryStream ms = new MemoryStream())
                {
                    product.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Todo: dynamic format
                    ms.Seek(0, SeekOrigin.Begin);
                    byte[] imgData = new byte[product.Image.Height * product.Image.Height];
                    ms.Read(imgData, 0, product.Image.Height * product.Image.Height);
                }*/

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product\n[Info]: " + ex.Message, "ProductsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Product Get(int id)
        {
            foreach(Product product in Products)
            {
                if(product.Id == id) 
                    return product;
            }

            return new Product();
        }

        public bool Exists(int id)
        {
            foreach (Product product in Products)
            {
                if (product.Id == id)
                    return true;
            }

            return false;
        }

        public void Delete(int id)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "DELETE FROM ProductsTbl WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show("Product #'" + id + "' is deleted", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete product\n[Info]: " + ex.Message, "ProductsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void AddQuantity(int id, int qty)
        {
            Product product = Get(id);
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "UPDATE ProductsTbl SET Quantity=@Quantity WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@Id", product.Id);
                cmd.Parameters.AddWithValue("@Quantity", product.Qty + qty);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product\n[Info]: " + ex.Message, "ProductsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public List<Product> CopyProducts()
        {
            List<Product> copy = new List<Product>();
            foreach(Product product in Products)
            {
                copy.Add(product);
            }

            return copy;
        }

        public void DeletingCategory(int catID)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "UPDATE ProductsTbl SET CategoryID='" + 0 + "' WHERE CategoryID='" + catID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update product\n[Info]: " + ex.Message, "ProductsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }

    public class CustomersDB
    {
        public List<Customer> Customers { get; private set; }

        public void Validate()
        {
            Customers = new List<Customer>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM CustomersTbl WHERE ParentAccountID='" + Account.Active.ParentAccountID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Customers.Add(new Customer
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        LastName = reader["LastName"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        MiddleInitial = reader["MiddleInitial"].ToString(),
                        Birthdate = Convert.ToDateTime(reader["Birthdate"]),
                        ContactNo = reader["ContactNo"].ToString(),
                        Email = reader["Email"].ToString(),
                        Points = Convert.ToDouble(reader["Points"]),
                        AmountSpent = Convert.ToDouble(reader["AmountSpent"])
                    });
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load CustomersTbl\n[Info]: " + ex.Message, "CustomersTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Add(Customer customer)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "INSERT INTO CustomersTbl(ParentAccountID, LastName, FirstName, MiddleInitial, Birthdate, ContactNo, Email, Points, AmountSpent) VALUES(@ParentAccountID, @LastName, @FirstName, @MiddleInitial, @Birthdate, @ContactNo, @Email, @Points, @AmountSpent)";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", Account.Active.ParentAccountID);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@MiddleInitial", customer.MiddleInitial);
                cmd.Parameters.AddWithValue("@Birthdate", customer.Birthdate);
                cmd.Parameters.AddWithValue("@ContactNo", customer.ContactNo);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Points", customer.Points);
                cmd.Parameters.AddWithValue("@AmountSpent", customer.AmountSpent);

                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show(customer.LastName + " is registered", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add customer\n[Info]: " + ex.Message, "CustomersTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Update(Customer customer)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "UPDATE CustomersTbl SET LastName=@LastName, FirstName=@FirstName, MiddleInitial=@MiddleInitial, Birthdate=@Birthdate, ContactNo=@ContactNo, Email=@Email, Points=@Points, AmountSpent=@AmountSpent WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@MiddleInitial", customer.MiddleInitial);
                cmd.Parameters.AddWithValue("@Birthdate", customer.Birthdate);
                cmd.Parameters.AddWithValue("@ContactNo", customer.ContactNo);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Points", customer.Points);
                cmd.Parameters.AddWithValue("@AmountSpent", customer.AmountSpent);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update customer\n[Info]: " + ex.Message, "CustomersTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Customer Get(int id)
        {
            foreach(Customer customer in Customers)
            {
                if (customer.Id == id)
                    return customer;
            }

            return new Customer();
        }

        public bool Exists(int id)
        {
            foreach (Customer customer in Customers)
            {
                if (customer.Id == id)
                    return true;
            }

            return false;
        }

        public void Delete(int id)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "DELETE FROM CustomersTbl WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show("Customer #'" + id + "' is deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete Customer\n[Info]: " + ex.Message, "CustomersTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }

    public class PrdCategoriesDB
    {
        public List<ProductCategory> Categories { get; private set; }

        public void Validate()
        {
            Categories = new List<ProductCategory>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM PrdCategoryTbl WHERE ParentAccountID='" + Account.Active.ParentAccountID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Categories.Add(new ProductCategory
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Category = reader["Category"].ToString(),
                        ParentCategory = reader["ParentCategory"].ToString(),
                        ParentCategoryID = Convert.ToInt32(reader["ParentCategoryID"])
                    });
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load PrdCategoryTbl\n[Info]: " + ex.Message, "PrdCategoryTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Add(ProductCategory category)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "INSERT INTO PrdCategoryTbl(ParentAccountID, Category, ParentCategory, ParentCategoryID) VALUES(@ParentAccountID, @Category, @ParentCategory, @ParentCategoryID)";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", Account.Active.ParentAccountID);
                cmd.Parameters.AddWithValue("@Category", category.Category);
                cmd.Parameters.AddWithValue("@ParentCategory", category.ParentCategory);
                cmd.Parameters.AddWithValue("@ParentCategoryID", category.ParentCategoryID);

                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show(category.Category + " is registered", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add category\n[Info]: " + ex.Message, "PrdCategoryTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Update(ProductCategory category)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                {
                    sqlConn.Open();
                    string sqlQueury = "UPDATE PrdCategoryTbl SET Category=@Category, ParentCategory=@ParentCategory, ParentCategoryID=@ParentCategoryID WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                    cmd.Parameters.AddWithValue("@Id", category.Id);
                    cmd.Parameters.AddWithValue("@Category", category.Category);
                    cmd.Parameters.AddWithValue("@ParentCategory", category.ParentCategory);
                    cmd.Parameters.AddWithValue("@ParentCategoryID", category.ParentCategoryID);

                    cmd.ExecuteNonQuery();
                    sqlConn.Close();
                }

                {
                    sqlConn.Open();
                    string sqlQueury = "UPDATE PrdCategoryTbl SET ParentCategory=@ParentCategory WHERE ParentCategoryID=@Id";
                    SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                    cmd.Parameters.AddWithValue("@Id", category.Id);
                    cmd.Parameters.AddWithValue("@ParentCategory", category.Category);

                    cmd.ExecuteNonQuery();
                    sqlConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update category\n[Info]: " + ex.Message, "PrdCategoryTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public ProductCategory Get(int id)
        {
            foreach (ProductCategory cat in Categories)
            {
                if (cat.Id == id)
                    return cat;
            }

            return new ProductCategory();
        }

        public ProductCategory Get(string category)
        {
            foreach (ProductCategory cat in Categories)
            {
                if (cat.Category == category)
                    return cat;
            }

            return new ProductCategory();
        }

        public bool Exists(int id)
        {
            foreach (ProductCategory cat in Categories)
            {
                if (cat.Id == id)
                    return true;
            }

            return false;
        }

        public bool Exists(string category)
        {
            foreach (ProductCategory cat in Categories)
            {
                if (cat.Category == category)
                    return true;
            }

            return false;
        }

        public void Delete(int id)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                {
                    sqlConn.Open();
                    string sqlQueury = "DELETE FROM PrdCategoryTbl WHERE Id='" + id + "'";
                    SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                    cmd.ExecuteNonQuery();
                    sqlConn.Close();
                }

                {
                    sqlConn.Open();
                    string sqlQueury = "UPDATE PrdCategoryTbl SET ParentCategory=@ParentCategory, ParentCategoryID=@ParentCategoryID WHERE ParentCategoryID=@Id";
                    SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@ParentCategory", "");
                    cmd.Parameters.AddWithValue("@ParentCategoryID", -1);

                    cmd.ExecuteNonQuery();
                    sqlConn.Close();
                }

                MessageBox.Show("Category #'" + id + "' is deleted", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete category\n[Info]: " + ex.Message, "PrdCategoryTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public List<ProductCategory> GetChildren(ProductCategory parent)
        {
            List<ProductCategory> children = new List<ProductCategory>();
            foreach(ProductCategory cat in Categories)
            {
                if(cat.ParentCategoryID == parent.Id)
                {
                    children.Add(cat);
                    children.AddRange(GetChildren(cat));
                }
            }
            return children;
        }

        public List<ProductCategory> GetParents(ProductCategory child)
        {
            List<ProductCategory> parents = new List<ProductCategory>();
            ProductCategory curParent = DB.PrdCategoriesDB.Get(child.ParentCategoryID);
            while (curParent.Id > 0)
            {
                parents.Add(curParent);
                curParent = DB.PrdCategoriesDB.Get(curParent.ParentCategory);
            }
            return parents;
        }
    }

    public class StaffsDB
    {
        public List<Account> Staffs { get; private set; }

        public void Validate()
        {
            Staffs = new List<Account>();
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM AccountsTbl WHERE ParentAccountID='" + Account.Active.ParentAccountID + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Staffs.Add(new Account
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        ParentAccountID = Convert.ToInt32(reader["ParentAccountID"]),
                        LastName = reader["LastName"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        MiddleInitial = reader["MiddleInitial"].ToString(),
                        Address = reader["Address"].ToString(),
                        ContactNo = reader["ContactNo"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        AccRole = (Account.Role)Convert.ToInt32(reader["Role"]),
                        AccStatus = (Account.Status)Convert.ToInt32(reader["Status"]),
                    });
                }

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load AccountsTbl\n[Info]: " + ex.Message, "AccountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Add(Account account)
        {
            account.ParentAccountID = Account.Active.ParentAccountID;

            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "INSERT INTO AccountsTbl(ParentAccountID, LastName, FirstName, MiddleInitial, Address, ContactNo, Email, Username, Password, Role, Status) VALUES(@ParentAccountID, @LastName, @FirstName, @MiddleInitial, @Address, @ContactNo, @Email, @Username, @Password, @Role, @Status)";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@ParentAccountID", account.ParentAccountID);
                cmd.Parameters.AddWithValue("@LastName", account.LastName);
                cmd.Parameters.AddWithValue("@FirstName", account.FirstName);
                cmd.Parameters.AddWithValue("@MiddleInitial", account.MiddleInitial);
                cmd.Parameters.AddWithValue("@Address", account.Address);
                cmd.Parameters.AddWithValue("@ContactNo", account.ContactNo);
                cmd.Parameters.AddWithValue("@Email", account.Email);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@Role", (int)account.AccRole);
                cmd.Parameters.AddWithValue("@Status", (int)account.AccStatus);

                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show(account.Username + " is registered", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add staff\n[Info]: " + ex.Message, "AccountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void Update(Account account)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "UPDATE AccountsTbl SET LastName=@LastName, FirstName=@FirstName, MiddleInitial=@MiddleInitial, Address=@Address, ContactNo=@ContactNo, Email=@Email, Username=@Username, Password=@Password, Role=@Role, Status=@Status WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@Id", account.Id);
                cmd.Parameters.AddWithValue("@LastName", account.LastName);
                cmd.Parameters.AddWithValue("@FirstName", account.FirstName);
                cmd.Parameters.AddWithValue("@MiddleInitial", account.MiddleInitial);
                cmd.Parameters.AddWithValue("@Address", account.Address);
                cmd.Parameters.AddWithValue("@ContactNo", account.ContactNo);
                cmd.Parameters.AddWithValue("@Email", account.Email);
                cmd.Parameters.AddWithValue("@Username", account.Username);
                cmd.Parameters.AddWithValue("@Password", account.Password);
                cmd.Parameters.AddWithValue("@Role", (int)account.AccRole);
                cmd.Parameters.AddWithValue("@Status", (int)account.AccStatus);

                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update staff\n[Info]: " + ex.Message, "AccountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Account Get(int id)
        {
            foreach(Account account in Staffs)
            {
                if (account.Id == id)
                    return account;
            }

            return new Account();
        }

        public bool Exists(int id)
        {
            foreach (Account account in Staffs)
            {
                if (account.Id == id)
                    return true;
            }

            return false;
        }

        public bool UsernameExists(string username, int ignoreAccID = -1)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);
                sqlConn.Open();
                string sqlQueury = "SELECT * FROM AccountsTbl WHERE Username COLLATE Latin1_General_CS_AS = @Username";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() && Convert.ToInt32(reader["Id"]) != ignoreAccID)
                    return true;

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load AccountsTbl\n[Info]: " + ex.Message, "AccountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return false;
        }

        public void Delete(int id)
        {
            try
            {
                SqlConnection sqlConn = new SqlConnection(DB.ConnectionString);

                sqlConn.Open();
                string sqlQueury = "DELETE FROM AccountsTbl WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(sqlQueury, sqlConn);

                cmd.ExecuteNonQuery();
                sqlConn.Close();

                MessageBox.Show("Staff #'" + id + "' is deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete staff\n[Info]: " + ex.Message, "AccountsTbl Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
