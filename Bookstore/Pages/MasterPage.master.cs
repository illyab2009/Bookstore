﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

        // SCAN BOOKS DATA FILE AND ADD ELEMENTS INTO a (static) MULTI-DIM. ARRAY

        //string csvText = @"C:\Users\SWE Group 4\Documents\Visual Studio 2017\WebSites\Bookstore\books.csv";


        StaticData.readFile(); //this will be moved to a more appropriate place later

    }

}