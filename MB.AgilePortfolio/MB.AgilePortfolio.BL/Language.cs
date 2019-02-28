﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.AgilePortfolio.PL;

namespace MB.AgilePortfolio.BL
{
    public class Language
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public Language() { }

        public Language(Guid id, string description)
        {
            Id = id;
            Description = description;
        }

        public void Insert()
        {
            try
            {
                using (PortfolioEntities dc = new PortfolioEntities())
                {
                    tblLanguage language = new tblLanguage()
                    {
                        Id = Guid.NewGuid(),
                        Description = Description
                    };
                    dc.tblLanguages.Add(language);
                    dc.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void Delete()
        {
            try
            {
                using (PortfolioEntities dc = new PortfolioEntities())
                {
                    tblLanguage language = dc.tblLanguages.Where(l => l.Id == Id).FirstOrDefault();
                    if (language != null)
                    {
                        dc.tblLanguages.Remove(language);
                        dc.SaveChanges();
                    }
                    else throw new Exception("Language not found");
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void Update()
        {
            try
            {
                using (PortfolioEntities dc = new PortfolioEntities())
                {
                    tblLanguage language = dc.tblLanguages.Where(l => l.Id == Id).FirstOrDefault();
                    if (language != null)
                    {
                        language.Description = Description;
                        dc.SaveChanges();
                    }
                    else throw new Exception("Language not found");
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void LoadById(Guid id)
        {
            try
            {
                using (PortfolioEntities dc = new PortfolioEntities())
                {
                    tblLanguage language = dc.tblLanguages.Where(l => l.Id == id).FirstOrDefault();
                    if (language != null)
                    {
                        Id = language.Id;
                        Description = language.Description;
                    }
                    else throw new Exception("Language not found");
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
    public class LanguageList : List<Language>
    {
        public void Load()
        {
            try
            {
                using (PortfolioEntities dc = new PortfolioEntities())
                {
                    var languages = dc.tblLanguages.OrderBy(l => l.Description);
                    foreach (var l in languages)

                    {
                        Language language = new Language(l.Id, l.Description);
                        Add(language);
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}

