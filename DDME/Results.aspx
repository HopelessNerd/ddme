<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" runat="Server">
    <style type="text/css">
        .risk-scale li {
            box-sizing: border-box;
            display: block;
            float: left;
            font-size: 1.6em;
            height: 60px;
            line-height: 24px;
            padding: 18px 20px;
            text-align: center;
            width: 25%;
            font-family: "HelveticaNeueBlack","HelveticaNeue-Black","HelveticaNeueLT Std Blk",arial;
            font-weight: 400;
            font-size: 1.0em;
        }

        .low {
            background-color: #84c449;
        }

        .increased {
            background-color: #fdde42;
        }

        .moderate {
            background-color: #f68b1f;
        }

        .high {
            background-color: #ec1d25;
        }

        .risk-scale li > span {
            background: #fff none repeat scroll 0 0;
            border-radius: 30px;
            color: #1e276e;
            display: block;
            height: 20px;
            line-height: 1.2em;
            padding-top: 6px;
        }

        section.results header div.container h4.pos60::after {
            left: 60%;
        }

        .h4::after {
            -moz-border-bottom-colors: none;
            -moz-border-left-colors: none;
            -moz-border-right-colors: none;
            -moz-border-top-colors: none;
            border-color: #30bae9 transparent transparent;
            border-image: none;
            border-style: solid;
            border-width: 12px;
            bottom: -24px;
            content: "";
            height: 0;
            left: 50%;
            margin-left: -12px;
            position: absolute;
            width: 0;
        }

        .header {
    background: #30bae9 none repeat scroll 0 0;
    color: #fff;
    font-size: 4em;
    margin-bottom: 12px;
    overflow: visible;
    padding: 0;
}
        * {
    -webkit-text-stroke: 0;
    margin: 0;
    outline: medium none;
    padding: 0;
}
    </style>

    <div class="header">
        <div class="container">
            <h4 class="pos60">Your risk is
                <b>Moderate</b>
                <br>
                Your answers add up to
                <b>19</b>
            </h4>
        </div>
    </div>
    <div class="container">

        <ul class="risk-scale ">

            <li class="low"><span><b>Low</b><span class="separator"> : </span>0 - 6</span></li>
            <li class="increased"><span><b>Increased</b><span class="separator"> : </span>7 - 15</span></li>
            <li class="moderate"><span><b>Moderate</b><span class="separator"> : </span>16 - 24</span></li>
            <li class="high"><span><b>High</b><span class="separator"> : </span>25 - 47</span></li>

        </ul>
    </div>

</asp:Content>

