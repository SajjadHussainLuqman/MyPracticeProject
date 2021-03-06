﻿using CommerceApp.DAL.EFramework;

namespace CommerceApp.BL.EFramework
{
    public interface IBrandRepository : IGenericRepository<Brand>
    {
        Brand GetSingle(int Id);
    }
}
