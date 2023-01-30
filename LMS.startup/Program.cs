using LMS.app.Services;
using LMS.Domain.Constants;
using LMS.Domain.MODELS;
using LMS.infrastructure.Services;
using LMS.Persistence.EF_Core;
using LMS.Persistence.Repositories;
using System;
using System.Security.Cryptography.X509Certificates;

namespace LMS.startup
{
    public delegate void HelloFunctionDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            EntityframeworkCore efCore = new EntityframeworkCore();
            efCore.EFCore();

        }




    }
}
