﻿using System.Net.Http;
using Wangkanai.Detection.Models;
using Xunit;

namespace Wangkanai.Detection
{
    internal static class MockClient
    {
        public static HttpRequestMessage CreateRequest(Device agent, string url = "/")
            => CreateRequest(agent.ToString(), url);

        public static HttpRequestMessage CreateRequest(string agent, string url = "/")
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("User-Agent", agent);
            return request;
        }
    }
}