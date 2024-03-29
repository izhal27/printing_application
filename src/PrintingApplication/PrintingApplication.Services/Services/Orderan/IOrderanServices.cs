﻿using PrintingApplication.Domain.Models.Orderan;

namespace PrintingApplication.Services.Services.Orderan
{
    public interface IOrderanServices : IBaseServicesGetByDate<IOrderanModel>, IBaseReportServicesByDate<IOrderanReportModel>
    {
        IOrderanModel GetByNoNota(object noNota);
    }
}
