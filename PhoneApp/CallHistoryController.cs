using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace PhoneApp
{
    public partial class CallHistoryController : UITableViewController
    {
        public List<string> PhoneNumbers { get; set; }
        protected NSString CallHistoryCellID = new NSString("CallHistoryCell");

        public CallHistoryController (IntPtr handle) : base (handle)
        {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), CallHistoryCellID);
            TableView.Source = new CallHistoryDataSource(this);
        }

        class CallHistoryDataSource : UITableViewSource
        {
            CallHistoryController Controller;

            public CallHistoryDataSource(CallHistoryController controller)
            {
                // Almacenar la instancia del UITableViewController.
                this.Controller = controller;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return Controller.PhoneNumbers.Count;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                // Devuelve un UITableViewCell reutilizable creado con el identificador
                // Controller.CallHistoryCellID
                var Cell = tableView.DequeueReusableCell(Controller.CallHistoryCellID);

                // Asignar el contenido a mostrar en la celda
                Cell.TextLabel.Text = Controller.PhoneNumbers[indexPath.Row];

                // Devolver la celda
                return Cell;
            }
        }
    }
}