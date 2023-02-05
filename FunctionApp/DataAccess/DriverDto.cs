﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveWorld.DataAccess
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DriverDto : DtoBase
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }
    }
}
