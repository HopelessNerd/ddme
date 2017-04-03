<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Con1" runat="Server">
    <style type="text/css">
        .gauge {
            position: relative;
            display: inline-block;
            font-size: 33px;
            line-height: 1em;
            height: 1em;
            width: 2em;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
        }

            .gauge.gauge-big {
                font-size: 117px;
            }

            .gauge.gauge-small {
                font-size: 17px;
            }

            .gauge:before {
                content: '';
                position: absolute;
                left: 0;
                top: 0;
                font-size: 100%;
                height: 2em;
                width: 2em;
                line-height: 1em;
                border: 0.35em solid #666666;
                -webkit-box-sizing: border-box;
                -moz-box-sizing: border-box;
                box-sizing: border-box;
                -webkit-border-radius: 100%;
                -moz-border-radius: 100%;
                -ms-border-radius: 100%;
                -o-border-radius: 100%;
                border-radius: 100%;
                clip: rect(auto, auto, 1em, auto);
            }

            .gauge .gauge-arrow {
                height: 1em;
                width: 0.075em;
                margin-left: -.05em;
                -webkit-transform-origin: 50% 100%;
                -moz-transform-origin: 50% 100%;
                -ms-transform-origin: 50% 100%;
                -o-transform-origin: 50% 100%;
                transform-origin: 50% 100%;
                -webkit-transition: all 0.5s;
                -moz-transition: all 0.5s;
                -o-transition: all 0.5s;
                transition: all 0.5s;
            }

                .gauge .gauge-arrow, .gauge .gauge-arrow:before {
                    position: absolute;
                    display: inline-block;
                    background: #A6A6A6;
                    left: 50%;
                    border-radius: 50% 50% 50% 50% / 50% 50% 0 0;
                    -webkit-box-sizing: border-box;
                    -moz-box-sizing: border-box;
                    box-sizing: border-box;
                }

                    .gauge .gauge-arrow:before {
                        content: '';
                        height: 0.15em;
                        width: 0.15em;
                        bottom: -0.1em;
                        margin-left: -0.075em;
                        border-radius: 100%;
                        -webkit-border-radius: 100%;
                        -moz-border-radius: 100%;
                        -ms-border-radius: 100%;
                        -o-border-radius: 100%;
                    }

        .gauge-rd.gauge:before {
            border-color: #ec1d25;
        }

        .gauge-range.gauge:before {
            border-color: #84c449;
        }
          .gauge-reen.gauge:before {
            border-color: #84c449;
        }


        .gauge-ellow.gauge:before {
            border-color: #fdde42;
        }

  
        .gauge-lue.gauge:before {
            border-color: #f68b1f;
        }



        /**********************************************/




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
            line-height: 0.8em;
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
    <section class="login-page">
        <div class="inner-banner demo-2 text-center">
            <header class="logo">
                <h1><a class="cd-logo link link--takiri" href="index.html">DDME <span style="margin-top: 10%">Diagnosing Diabetes Made Easy.</span></a></h1>
                px;
            </header>
            <div id="breadcrumb_wrapper">
                <div class="container">
                    <h2>Test Result</h2>
                </div>
            </div>
        </div>
        <div class="login">
            <div class="container">
                <div class="alert alert-info alert-dismissable col-lg-12" style="margin-bottom: 0px;">
                    <form name="frm1" runat="server">
                        <asp:HiddenField ID="hf1" Value="80" runat="server" />
                        <div id="gaugeDemo" class="gauge gauge-big gauge-green  col-lg-6">
                            <div class="gauge-arrow" data-percentage="<%=hf1.Value %>"
                                style="transform: rotate(0deg);">
                            </div>
                        </div>
                        <div class="">
                            <asp:HiddenField ID="hf2" runat="server" Value="" />
                            <h1>Your Score is : <%=hf2.Value %> </h1>
                        </div>
                    </form>
                </div>
                <ul class="risk-scale ">
                    <li class="low"><span><b>Low</b><span class="separator"> : </span>0 - 6</span></li>
                    <li class="increased"><span><b>Increased</b><span class="separator"> : </span>7 - 15</span></li>
                    <li class="moderate"><span><b>Moderate</b><span class="separator"> : </span>16 - 24</span></li>
                    <li class="high"><span><b>High</b><span class="separator"> : </span>25 - 47</span></li>
                </ul>
            </div>
        </div>
    </section>
    <!-- //login-section -->
    <div class="clearfix"></div>
    <script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>
    <script src="js/cmGauge.js"></script>
    <script type="text/javascript">
        $(function () {
            $('#gaugeDemo .gauge-arrow').cmGauge();
        });
    </script>

</asp:Content>

