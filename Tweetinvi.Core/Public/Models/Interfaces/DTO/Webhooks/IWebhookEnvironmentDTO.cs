﻿using Tweetinvi.Models.DTO;

namespace Tweetinvi.Core.Public.Models.Interfaces.DTO.Webhooks
{
    public interface IWebhookEnvironmentDTO
    {

        string EnvironmentName { get; set; }
        IWebhookDTO[] Webhooks { get; set; }
    }
}