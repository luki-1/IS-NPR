using web.Data;
using web.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NepremicnineContext context)
        {
            context.Database.EnsureCreated();
            
             var nepremicninas = new Nepremicnina[]
            {
                new Nepremicnina{ID=1,Naslov="asd"},
                new Nepremicnina{ID=2,Naslov="qwe"},
                new Nepremicnina{ID=3,Naslov="yxc"}
            };

            context.SaveChanges();
        }
    }
}