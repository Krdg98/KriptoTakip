﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.SQLite
{
    public class SqliteCoinDal : EfEntityFrameworkBase<Coin, SQLiteDbContext>, ICoinDal
    {
    }
}
