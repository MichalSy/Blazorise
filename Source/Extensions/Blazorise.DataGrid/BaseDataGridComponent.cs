﻿#region Using directives
using System;
using Blazorise.Utilities;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise.DataGrid
{
    /// <summary>
    /// Minimal base class for datagrid components.
    /// </summary>
    public class BaseDataGridComponent : ComponentBase, IDisposable
    {
        #region Members

        private string elementId;

        #endregion

        #region Methods

        public void Dispose()
        {
            Dispose( true );
        }

        protected virtual void Dispose( bool disposing )
        {
            if ( !Disposed )
            {
                Disposed = true;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or set the javascript runner.
        /// </summary>
        [Inject] protected IIdGenerator IdGenerator { get; set; }

        protected bool Disposed { get; private set; }

        /// <summary>
        /// Gets or sets the element id.
        /// </summary>
        public string ElementId
        {
            get
            {
                // generate ID only on first use
                if ( elementId == null )
                    elementId = IdGenerator.Generate;

                return elementId;
            }
            private set
            {
                elementId = value;
            }
        }

        #endregion
    }
}
