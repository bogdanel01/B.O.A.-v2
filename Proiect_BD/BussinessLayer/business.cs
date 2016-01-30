﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class clsBusiness_get_Administratori
    {
        public static IQueryable<DataLayer.Models.newAdministratori> get_Administratori()
        {
            return DataLayer.Models.Administratori.get_Administratori();
        }
        public static bool insert_Administratori(string nume, string prenume, int grad)
        {
            int ok = 0;
            var listgrade = DataLayer.Models.Grade.get_Grade().ToList();
            foreach (var item in listgrade)
                if (item.ID_Grad == grad) ok = 1;
            if(ok==0)
                return false;
                    
            DataLayer.Models.Administratori.insert_Administratori(nume,prenume,grad);
            return true;
        }
        public static void delete_Administratori(int id)
        {
            DataLayer.Models.Administratori.delete_Administratori(id);
        }
        public static bool update_Administratori(int id, string nume, string prenume, int grad)
        {
            int ok = 0;
            var listgrade = DataLayer.Models.Grade.get_Grade().ToList();
            foreach (var item in listgrade)
                if (item.ID_Grad == grad) ok = 1;
            if (ok == 0)
                return false;
            DataLayer.Models.Administratori.update_Administratori(id, nume, prenume, grad);
            return true;
        }
    }
    public class clsBusiness_get_AlocareHrana
    {
        public static IQueryable<DataLayer.Models.newAlocareHrana> get_AlocareHrana()
        {
            return DataLayer.Models.AlocareHrana.get_AlocareHrana();
        }
        public static void insert_AlocareHrana(int student, int pret, int admin, int counter)
        {
            DataLayer.Models.AlocareHrana.insert_AlocareHrana(student,pret,admin,counter);
        }
        public static void delete_AlocareHrana(int student, int pret)
        {
            DataLayer.Models.AlocareHrana.delete_AlocareHrana(student,pret);
        }
        public static void update_AlocareHrana(int student, int pret, int admin, int counter)
        {
            DataLayer.Models.AlocareHrana.update_AlocareHrana(student, pret, admin, counter);
        }
    }
    public class clsBusiness_get_Articole_Drepturi
    {
        public static IQueryable<DataLayer.Models.newArticoleDrepturi> get_Articole_Drepturi()
        {
            return DataLayer.Models.ArticoleDrepturi.get_ArticoleDrepturi();
        }
    }
    public class clsBusiness_get_ArticoleVest
    {
        public static IQueryable<DataLayer.Models.newArticoleVest> get_ArticoleVest()
        {
            return DataLayer.Models.ArticoleVest.get_ArticoleVest();
        }
    }
    public class clsBusiness_get_CDT_Comp
    {
        public static IQueryable<DataLayer.Models.newCDT_Comp> get_CDT_Comp()
        {
            return DataLayer.Models.CDT_Comp.get_CDT_comp();
        }
        public void insert_CDT_Comp(string nume, string prenume, int grad)
        {
            DataLayer.Models.CDT_Comp.insert_CDT_Comp(nume, prenume, grad);
        }
        public static void delete_CDT_Comp(int id)
        {
            DataLayer.Models.CDT_Comp.delete_CDT_Comp(id);
        }
        public static void update_CDT_Comp(int id, string nume, string prenume, int grad)
        {
            DataLayer.Models.CDT_Comp.update_CDT_Comp(id, nume, prenume, grad);
        }
    }
    public class clsBusiness_get_Companie
    {
        public static IQueryable<DataLayer.Models.newCompanie> get_Companie()
        {
            return DataLayer.Models.Companie.get_Companie();
        }
        public static void insert_Companie(string nume, int com, int admin)
        {
            DataLayer.Models.Companie.insert_Companie(nume,com,admin);
        }
        public static void delete_Companie(int id)
        {
            DataLayer.Models.Companie.delete_Companie(id);
        }
        public static void update_Companie(int id, string nume, int com, int admin)
        {
            DataLayer.Models.Companie.update_Companie(id, nume, com, admin);
        }
    }
    public class clsBusiness_get_Grade
    {
        public static IQueryable<DataLayer.Models.Grade> get_Grade()
        {
            return DataLayer.Models.Grade.get_Grade();
        }
    }
    public class clsBusiness_get_Preturi
    {
        public static IQueryable<DataLayer.Models.Preturi> get_Preturi()
        {
            return DataLayer.Models.Preturi.get_Preturi();
        }
    }
    public class clsBusiness_get_Student
    {
        public static IQueryable<DataLayer.Models.newStudent> get_Student()
        {
            return DataLayer.Models.Student.get_Student();
        }
    }
}
