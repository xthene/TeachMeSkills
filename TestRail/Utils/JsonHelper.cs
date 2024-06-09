﻿using System.Text.Json;
using TestRail.Models;

namespace TestRail.Utils
{
    public class JsonHelper
    {
        public JsonObject1 FromJson(string path)
        {
            using FileStream fs = new FileStream(path, FileMode.Open);
            return JsonSerializer.Deserialize<JsonObject1>(fs);
        }

        public string ToJson(JsonObject1 object1)
        {
            return JsonSerializer.Serialize(object1);
        }
    }
}
