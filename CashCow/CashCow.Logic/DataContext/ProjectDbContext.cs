﻿//@BaseCode
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashChow.Logic.DataContext
{
	internal partial class ProjectDbContext : DbContext, Contracts.IContext
	{
	}
}
