﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace LlmClient.Models
{
    public interface IGroqApiClient
    {
        Task<JsonObject?> CreateChatCompletionAsync(JsonObject request);

        IAsyncEnumerable<JsonObject?> CreateChatCompletionStreamAsync(JsonObject request);
    }
}
