using Currency;
using Currency.US;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2._1Core.Models
{
    public class RepoViewModel
{
        public ICurrencyRepo repo;

        public RepoViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
        }
        [Display(Name = "TotalValue")]
        public decimal TotalValue => repo.TotalValue();
        //{
        //    get { return repo.TotalValue(); }
        //}

        public void MakeChange(decimal Amount)
        {
            repo.ClearChange();
            repo.MakeChange(Amount);
        }
        [HiddenInput(DisplayValue = false)]
        public List<ICoin> Coins => repo.Coins;
        //{
        //    get { return repo.Coins; }
        //}

    }
}
