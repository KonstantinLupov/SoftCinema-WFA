﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftCinema.Services.Utilities.Validators
{
    public static class CategoryValidator
    {
        public static void ValidateCategoryDoesNotExist(string categoryName)
        {
            if (CategoryService.IsCategoryExisting(categoryName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CategoryAlreadyExists, categoryName));
            }
        }

        public static void CheckCategoriesExist(List<string> categories)
        {
            foreach (var category in categories)
            {
                CheckCategoryExists(category);
            }
        }

        private static void CheckCategoryExists(string categoryName)
        {
            if (!CategoryService.IsCategoryExisting(categoryName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CategoryDoesntExist, categoryName));
            }
        }
    }
}
