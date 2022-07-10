using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FinalApp.Controllers.APIControllers
{
    public class PlayerAPIController : BaseClassController
    {
        // GET: PlayerAPI
        [HttpGet]
        public ActionResult GetAllPlayers()
        {
            var players = nba.Players.GetAll();
            return Json(players, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetPlayerById(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var player = nba.Players.GetById(id);
            if (player is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            return Json(player, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeletePlayer(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var player = nba.Players.GetById(id);
            if (player is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            nba.Players.Delete(id);
            nba.Complete();

            return Json(player, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreatePlayer(Player player)
        {
            if (ModelState.IsValid)
            {
                nba.Players.Insert(player);
                nba.Players.Save();
                return Json(player, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotAcceptable);
            }
        }

        [HttpPost]
        public ActionResult UpdatePlayer(int? id, Player player)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var playerToUpdate = nba.Players.GetById(id);

            if (playerToUpdate is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            // Mapping 
            playerToUpdate.FirstName = player.FirstName;
            playerToUpdate.LastName = player.LastName;
            playerToUpdate.DateOfBirth = player.DateOfBirth;
            playerToUpdate.TotalPoints = player.TotalPoints;
            playerToUpdate.TotalAsists = player.TotalAsists;
            playerToUpdate.StatusOfLife = player.StatusOfLife;

            if (ModelState.IsValid)
            {
                nba.Players.Update(playerToUpdate);
                nba.Complete();
                return Json(playerToUpdate, JsonRequestBehavior.AllowGet);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }



    }
}