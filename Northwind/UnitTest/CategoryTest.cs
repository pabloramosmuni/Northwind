using BackEnd.DAL;
using BackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest
{
   public class CategoryTest
    {
        [Fact]
        public void TestAdd()
        {
            Category category = new Category
            {
                CategoryName = "PruebaNotTgyghyfghfghfhfgh"
            };

            NorthWndContext context = new NorthWndContext();
            using (UnidadDeTrabajo<Category> unidad = 
                new UnidadDeTrabajo<Category>(context))
            {

                bool result; 
                    unidad.genericDAL.Add(category);
                result =  unidad.Complete();
                Assert.True(!result, "Inserciòn correcta");

            }



        }

    }
}
