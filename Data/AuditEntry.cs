﻿using Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Data
{
    public class AuditEntry
    {
        public EntityEntry EntityEntry { get; }
        public string Action { get; set; }
        public string TableName { get; set; }
        public Dictionary<string, object> KeyValues { get; set; } = new Dictionary<string, object>();
        public Dictionary<string, object> OldValues { get; set; } = new Dictionary<string, object>();
        public Dictionary<string, object> NewValues { get; set; } = new Dictionary<string, object>();
        public List<PropertyEntry> TemporaryProperties { get; } = new List<PropertyEntry>();
        public bool HasTemporaryProperties => TemporaryProperties.Any();

        public AuditEntry(EntityEntry entityEntry)
        {
            EntityEntry = entityEntry;
        }

        public Audit ToAudit()
        {
            var audit = new Audit()
            {
                DateTime = DateTime.Now,
                TableName = TableName,
                KeyValues = JsonConvert.SerializeObject(KeyValues),
                OldValues= OldValues.Count == 0 ? null : JsonConvert.SerializeObject(OldValues),
                NewValues= NewValues.Count == 0 ? null : JsonConvert.SerializeObject(NewValues),
                Action= Action
            };

            return audit;
        }
    }
}