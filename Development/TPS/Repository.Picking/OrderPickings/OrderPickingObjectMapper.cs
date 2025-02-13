﻿using Business.Domain.People;
using Business.Domain.Picking;
using Database.Picking.Entities;
using Repository.Picking.PickingItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Picking.OrderPickings
{
    internal static class OrderPickingObjectMapper
    {
        public static OrderPicking ToDomain(this OrderPickingEntity entity, Operator op) {
            if (entity == null)
                return null;

            var lastStatus = entity.Processes.OrderBy(o => o.Date).LastOrDefault();

            var model = new OrderPicking(entity.Id, lastStatus.Container, lastStatus.Sector, (PickingStatus)lastStatus.Status_Id, op)
            {
                Description = entity.Description
            };

            entity.Details.ToList().ForEach(detail => model.Details.Add(detail.Name, detail.Value));
            entity.Items.ToList().ForEach(item => model.Items.Add(item.ToDomain()));
            return model;
        }
    }
}
