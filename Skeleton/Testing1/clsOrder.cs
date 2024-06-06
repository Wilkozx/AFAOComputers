using System;

internal class clsOrder
{
    internal int OrderID;
    internal int OrderId;
    internal string Status;
    internal string ShipmentDate;
    internal DateTime OrderDate;
    internal int ShipmentID;
    internal string Quantity;

    public bool Visible { get; internal set; }

    internal void Find(int primaryKey)
    {
        throw new NotImplementedException();
    }

    internal string Valid(string orderID, object status, object shipmentDate, object quantity, object )
    {
        throw new NotImplementedException();
    }

    internal string Valid(string orderID, object status, object paymentMethod, object quantity)
    {
        throw new NotImplementedException();
    }

    internal string Valid(object orderID, object status, object paymentMethod, object quantity)
    {
        throw new NotImplementedException();
    }

    internal string Valid(object orderID, string status, object paymentMethod, object quantity)
    {
        throw new NotImplementedException();
    }
}