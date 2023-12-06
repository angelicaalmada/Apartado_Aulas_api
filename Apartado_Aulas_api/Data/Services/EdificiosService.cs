using Apartado_Aulas_api.Data.Models;
using Apartado_Aulas_api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Apartado_Aulas_api.Data.Services
{
    public class EdificiosService
    {
        private AppDbContext _context;
        public EdificiosService(AppDbContext context)
        {
            _context = context;

        }

        //Metodo que nos permite agregar un nuevo edificio en la BD

        public void AddEdificio(EdificioVM edificio)
        {
            var _edificio = new Edificio()
            {
                NumeroEdificio = edificio.NumeroEdificio,
                NombreEdificio = edificio.NombreEdificio,
                Encargado = edificio.Encargado,
                CantAulas = edificio.CantAulas,
            };
            _context.Edificios.Add(_edificio);
            _context.SaveChanges();
        }
        //Metodo que nos permite obtener una lista de todos los edificios en la BD
        public List<Edificio> GetAllEdif()=> _context.Edificios.ToList();

        //Metodo que nos permite obtener el edificios que estamos pidiendo en la BD
        public Edificio GetEdificioById(int edificioid) => _context.Edificios.FirstOrDefault(n => n.Id == edificioid);

        //Metodo que nos permite modificar un edificio que se encuentra en la BD
        public Edificio UpdateEdificioByID(int edificioid, EdificioVM edificio)
        {
            var _edificio = _context.Edificios.FirstOrDefault(n =>n.Id == edificioid);
            if(_edificio != null)
            {
                _edificio.NumeroEdificio = edificio.NumeroEdificio;
                _edificio.NombreEdificio = edificio.NombreEdificio;
                _edificio.Encargado = edificio.Encargado;
                _edificio.CantAulas = edificio.CantAulas;

                _context.SaveChanges() ;
            }
            return _edificio;
        }

        public void DeleteEdificioById(int edificioid)
        {
            var _edificio = _context.Edificios.FirstOrDefault(n => n.Id == edificioid);
            if(_edificio != null)
            {
                _context.Edificios.Remove(_edificio);
                _context.SaveChanges() ;
            }
        }
    }
}
