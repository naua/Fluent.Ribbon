﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Markup;

namespace Fluent
{
    /// <summary>
    /// Represents size definition for group box
    /// </summary>
    [ContentProperty("Children")]
    public class RibbonToolBarRow : DependencyObject
    {
        #region Fields

        // User defined rows
        readonly ObservableCollection<DependencyObject> children = new ObservableCollection<DependencyObject>();

        #endregion

        #region Properties

        #region Children Property

        /// <summary>
        /// Gets rows
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<DependencyObject> Children
        {
            get { return children; }
        }

        #endregion

        #endregion

        #region Initialization

        /// <summary>
        /// Default constructor
        /// </summary>
        public RibbonToolBarRow(){}

        #endregion

        internal void Invalidate()
        {
            throw new NotImplementedException();
        }
    }
}