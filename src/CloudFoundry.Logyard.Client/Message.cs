﻿using Newtonsoft.Json;
using System;

namespace CloudFoundry.Logyard.Client
{
    public class Message
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonIgnore]
        public MessageValue Value { get; set; }
    }

    public class MessageValue
    {
        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("instance_index")]
        public int InstanceIndex { get; set; }

        [JsonProperty("app_guid")]
        public Guid AppGuid { get; set; }

        [JsonProperty("app_name")]
        public string AppName { get; set; }

        [JsonProperty("app_space")]
        public string AppSpace { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("unix_time")]
        public long UnixTime { get; set; }

        [JsonProperty("human_time")]
        public string HumanTime { get; set; }

        [JsonIgnore]
        public ValueSyslog Syslog { get; set; }
    }

    public class ValueSyslog
    {
        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }
}