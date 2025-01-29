﻿using ApiIosep.Models.IOSEP;
using ApiIosep.Repositorio.Interfaces;
using ApiIosep.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace ApiIosep.Services.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IOSEPContext _context;
        private IDbContextTransaction _transaction;
        public UnitOfWork(IOSEPContext context)
        {
            _context = context;
        }

        
        // Iniciar una transacción
        public async Task BeginTransactionAsync()
        {
            if (_transaction == null)
            {
                _transaction = await _context.Database.BeginTransactionAsync();
            }
        }

        // Confirmar la transacción
        public async Task CommitAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                if (_transaction != null)
                {
                    await _transaction.CommitAsync();
                }
            }
            catch
            {
                await RollbackAsync();
                throw;
            }
        }

        // Revertir los cambios si hay un error
        public async Task RollbackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            _transaction?.Dispose();
        }
    }
}
