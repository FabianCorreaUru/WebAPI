using FireBaseManager.Dto;
using FireBaseManager.Manager;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebApiFabian.Context;
using WebApiFabian.Modelos;
using System.Diagnostics;

namespace AppCrudFabian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class NotificationsController : ControllerBase
    {
        private readonly IFirebaseNotificationsRepository _firebaseNotificationsRepository;
        
        public NotificationsController(IFirebaseNotificationsRepository firebaseNotificationsRepository)
        {
            _firebaseNotificationsRepository = firebaseNotificationsRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Send(MessageDto message)
        {
            bool result = await _firebaseNotificationsRepository.SendPushNotification(message);
            if (result) return Ok();
            else return BadRequest();
        }

    }

}
