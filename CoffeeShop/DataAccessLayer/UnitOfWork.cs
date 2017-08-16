using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork
    {
        SqlContext _dbContext;
        DbContextTransaction _transaction;

        public UnitOfWork()
        {
            _dbContext = new SqlContext();
            _transaction = _dbContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
        }

        private CategoryRepository _categoryRepo;

        public CategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepo == null)
                {
                    _categoryRepo = new CategoryRepository(_dbContext);
                }
                return _categoryRepo;
            }
        }
        //Örnek hazıladım CategoryRepository şekilde diğer repositorylerde doldurulacak


        private SupplierRepository _supplierRepo;
        public SupplierRepository SupplierRepository
        {
            get
            {
                if (_supplierRepo == null)
                    _supplierRepo = new SupplierRepository(_dbContext);

                return _supplierRepo;
            }
        }



        private RawMaterialRepository _rawMaterialRepo;
        public RawMaterialRepository RawMaterialRepository
        {
            get
            {
                if (_rawMaterialRepo == null)
                    _rawMaterialRepo = new RawMaterialRepository(_dbContext);

                return _rawMaterialRepo;
            }

        }


        private CheckRepository _checkRepo;
        public CheckRepository CheckRepository
        {
            get
            {
                if (_checkRepo == null)
                    _checkRepo = new CheckRepository(_dbContext);

                return _checkRepo;
            }
        }

        private FormulaRepository _formulaRepo;
        public FormulaRepository FormulaRepository
        {
            get
            {
                if (_formulaRepo == null)
                    _formulaRepo = new FormulaRepository(_dbContext);

                return _formulaRepo;
            }
        }

        private GenderRepository _genderRepo;
        public GenderRepository GenderRepository
        {
            get
            {
                if (_genderRepo == null)
                    _genderRepo = new GenderRepository(_dbContext);

                return _genderRepo;
            }
        }

        private OrderRepository _orderRepo;
        public OrderRepository OrderRepository
        {
            get
            {
                if (_orderRepo == null)
                    _orderRepo = new OrderRepository(_dbContext);

                return _orderRepo;
            }
        }

        private ProductRepository _productRepo;
        public ProductRepository ProductRepository
        {
            get
            {
                if (_productRepo == null)
                    _productRepo = new ProductRepository(_dbContext);

                return _productRepo;
            }
        }


        private RawUnitRepository _rawUnitRepo;
        public RawUnitRepository RawUnitRepository
        {
            get
            {
                if (_rawUnitRepo == null)
                    _rawUnitRepo = new RawUnitRepository(_dbContext);

                return _rawUnitRepo;
            }
        }

        private TableRepository _tableRepo;
        public TableRepository TableRepository
        {
            get
            {
                if (_tableRepo == null)
                    _tableRepo = new TableRepository(_dbContext);

                return _tableRepo;
            }
        }

        private TableStatusRepository _tableStatusRepo;
        public TableStatusRepository TableStatusRepository
        {
            get
            {
                if (_tableStatusRepo == null)
                    _tableStatusRepo = new TableStatusRepository(_dbContext);

                return _tableStatusRepo;
            }
        }

        private TitleRepository _titleRepo;
        public TitleRepository TitleRepository
        {
            get
            {
                if (_titleRepo == null)
                    _titleRepo = new TitleRepository(_dbContext);

                return _titleRepo;
            }
        }

        private UserRepository _userRepo;
        public UserRepository UserRepository
        {
            get
            {
                if (_userRepo == null)
                    _userRepo = new UserRepository(_dbContext);

                return _userRepo;
            }
        }

        public bool ApplyChanges()
        {
            bool isSuccess = false;
            try
            {
                _dbContext.SaveChanges();
                _transaction.Commit();
                isSuccess = true;
            }

            catch (Exception)
            {

                _transaction.Rollback();
                isSuccess = false;

            }
            finally
            {
                _transaction.Dispose();
            }
            return isSuccess;

        }

    }
}
