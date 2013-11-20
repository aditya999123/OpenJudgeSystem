﻿namespace OJS.Web.Areas.Administration.ViewModels.Setting
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq.Expressions;
    using OJS.Common.DataAnnotations;
    using OJS.Data.Models;

    public class SettingAdministrationViewModel
    {
        [ExcludeFromExcel]
        public static Expression<Func<Setting, SettingAdministrationViewModel>> ViewModel
        {
            get
            {
                return set => new SettingAdministrationViewModel
                {
                    Name = set.Name,
                    Value = set.Value,
                };
            }
        }

        [ExcludeFromExcel]
        public Setting ToEntity
        {
            get
            {
                return new Setting
                {
                    Name = this.Name,
                    Value = this.Value,
                };
            }
        }

        [Display(Name = "Име")]
        [Required(ErrorMessage = "Името е задължително!")]
        [UIHint("SingleLineText")]
        public string Name { get; set; }

        [Display(Name = "Стойност")]
        [Required(ErrorMessage = "Стойността е задължителна!")]
        [UIHint("MultiLineText")]
        public string Value { get; set; }
    }
}