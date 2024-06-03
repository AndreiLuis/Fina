﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    public abstract class Response<TData>
    {
        private int _code = Configuration.DefaultStatusCode;

        public Response() 
            => _code = Configuration.DefaultStatusCode;
        public Response
            (
            TData? data,
            int code = Configuration.DefaultStatusCode, 
            string? message = null
            )
        {
            _code = code;
            Message = message;
            Data = data;
        }

        public string? Message {  get; set; }
        public TData? Data { get; set; } 

        [JsonIgnore]
        public bool IsSuccess => _code is > 200 and < 299;
    }
}
