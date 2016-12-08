﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.Mvc;

using AutoMapper;

using Potatotech.GestaoRestaurante.Dominio.Models;



using Potatotech.GestaoRestaurante.Persistencia.UnitsOfWork;

using Potatotech.GestaoRestaurante.Web.ViewModels;





namespace Potatotech.GestaoRestaurante.Repositories.Controllers

{

    public class GarcomController : Controller

    {



        private UnitOfWork _unit = new UnitOfWork();

        // GET: Garcom

        public ActionResult Index()

        {

            return RedirectToAction("Pedido");

        }



        public ActionResult Pedido()

        {

            return View();

        }



        public ActionResult HistoricoPedidos()

        {

            List<Pedido> pedidos = _unit.PedidoRepository.Listar().ToList();

            var pedidosvm = Mapper.Map<List<PedidoViewModel>>(pedidos);

            return View(pedidosvm);

        }

    }

}