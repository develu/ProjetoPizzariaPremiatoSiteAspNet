using PizzariaPremiatoDTO.Categoria;
using PizzariaPremiatoDTO.Pizza;
using PizzariaPremiatoRepositorio.Database;
using PizzariaPremiatoRepositorio.Entidades;
using PizzariaPremiatoRepositorio.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzariaPremiatoRepositorio.repositorio
{
    public class PizzaRepositorio : IPizzaRepositorio
    {
        private DatabaseContext _contexto;

        public PizzaRepositorio(DatabaseContext contexto)
        {
            this._contexto = contexto;
        }

        public void Cadastrar(PizzaDTO dto)
        {
            var entity = new Pizza()
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao,
                CategoriaId = dto.Categoria.Id,
                DataCadastro = dto.DataCadastro,
                FotoBase64 = dto.Foto,
                Valor = dto.Valor
            };

            _contexto.PizzaEntity.Add(entity);
            _contexto.SaveChanges();
        }

        public void Editar(PizzaDTO dto)
        {
            var entity = _contexto.PizzaEntity.Where(p => p.Id == dto.Id).FirstOrDefault();

            if (entity == null)
            {
                throw new ArgumentException("Pizza not found");
            }
            else
            {
                entity.Nome = dto.Nome;
                entity.Descricao = dto.Descricao;
                entity.CategoriaId = dto.Categoria.Id;
                entity.FotoBase64 = string.IsNullOrEmpty(dto.Foto) ? entity.FotoBase64 : dto.Foto;
                entity.Valor = dto.Valor;
            }

            _contexto.PizzaEntity.Update(entity);
            _contexto.SaveChanges();

        }

        public List<Pizza> ListarPizza()
        {
            List<Pizza> lst = _contexto.PizzaEntity.ToList();

            foreach (var p in lst)
            {
                p.Categoria = _contexto.CategoriaEntity.Where(c => c.Id == p.CategoriaId).FirstOrDefault();
            }

            return lst;

        }

        public void Deletar(int idPizza)
        {
            var entity = _contexto.PizzaEntity.Where(p => p.Id == idPizza).FirstOrDefault();

            if (entity == null)
            {
                throw new ArgumentException("Pizza not found");
            }
            else
            {
                _contexto.PizzaEntity.Remove(entity);
                _contexto.SaveChanges();
            }
        }

        public PizzaDTO BuscarPizzaPorId(int idPizza)
        {
            var entity = _contexto.PizzaEntity.Where(p => p.Id == idPizza).FirstOrDefault();

            if (entity == null)
            {
                throw new ArgumentException("Pizza not found");
            }
            else
            {
                var entityCategoria = _contexto.CategoriaEntity.Where(c => c.Id == entity.CategoriaId).FirstOrDefault();

                return new PizzaDTO()
                {
                    Id = entity.Id,
                    Nome = entity.Nome,
                    Descricao = entity.Descricao,
                    DataCadastro = entity.DataCadastro,
                    Foto = entity.FotoBase64,
                    Valor = entity.Valor,
                    Categoria = new CategoriaDTO()
                    {
                        Id = entityCategoria.Id
                    }
                };
            }            
        }
    }
}
