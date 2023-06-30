using Proyecto_CGS.Context;
using Proyecto_CGS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CGS.Controladores
{
    internal class EquipoController
    {
        ModelVentaDeComputadoras _context = new ModelVentaDeComputadoras();
        public bool Login(string usuario, string password)
        {
            var UsuarioLogin = _context.Usuario.Where(x => x.NombreUsuario == usuario && x.PasswordUsuario == password).SingleOrDefault();
            if (UsuarioLogin != null) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //CRUD DEVUELVA TODO
        public List<Equipo> GetAll()
        {
            return _context.Equipo.ToList();
        }
        //PARA QUE DEVUELVA UN SOLO EQUIPO
        public Equipo Get(String MarcaEuipo)
        {
            return _context.Equipo.Find(MarcaEuipo);
        }
        //BUSCAR
        public List<Equipo>Search(String pars) 
        {
            if(String.IsNullOrEmpty(pars))
            {
                return GetAll();
            }
            else
            {
                return _context.Equipo.Where(x => x.MarcaEquipo.Contains(pars) || x.ModeloEquipo.Contains(pars)).ToList();

            }
        }
        public bool create (Equipo equi)
        {
            _context.Equipo.Add(equi);
            return _context .SaveChanges()>0;
        }
        public bool Update(Equipo equi)
        {
            _context.Equipo.Attach(equi);
            _context.Entry(equi).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges()>0;
        }
        public bool Delete(Equipo equi) 
        {
            _context.Equipo.Remove(equi);  
            return _context .SaveChanges()>0;  
        }
    }
}
