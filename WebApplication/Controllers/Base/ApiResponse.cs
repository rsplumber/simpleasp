﻿namespace WebApplication.Controllers.Base
{
    public class ApiResponse<T>
    {
        public Meta Meta { get; set; }
        public  Data<T> Data { get; set; }

        public ApiResponse(T data)
        {
            Meta = new Meta(0 ,"NoMessage");
            Data = new Data<T>(data);
        }

        public ApiResponse<T> StatusCode(int code)
        {
            this.Meta.Code = code;
            return this;
        }

        public ApiResponse<T> Message(string message)
        {
            this.Meta.Message = message;
            return this;
        }


    }

    public class Meta
    {
        public Meta(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public int Code { get; set; }

        public string Message { get; set; }
    }

    public class Data<T>
    {
        public Data(T content)
        {
            Content = content;
        }

        public T Content { get; set; }
    }
}