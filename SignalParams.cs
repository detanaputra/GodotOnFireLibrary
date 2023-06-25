using Godot;
using Godot.Collections;

using System;

namespace GodotOnFireLibrary
{
    public class SignalParams : Node
    {
        public int Status { get; set; } = 1;
        public string Message { get; set; } = string.Empty;
        public string Data { get; set; } = string.Empty;

        public SignalParams(Dictionary param)
        {
            try
            {
                Status = (int)param["status"];
                Message = (string)param["message"];
                if (param.Contains("data"))
                {
                    Data = (string)param["data"];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}