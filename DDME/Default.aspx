<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="~/MasterPage.master" %>

<asp:Content Id="containt1" ContentPlaceHolderID="Con1" runat="server">


        <!-- //header -->
	<div class="demo-2">	
		<header class="logo">
			<h1><a class="cd-logo link link--takiri" href="default.aspx">DDME </a></h1>
		</header>
            <div id="slider" class="sl-slider-wrapper">

				<div class="sl-slider">
				
					<div class="sl-slide" data-orientation="horizontal" data-slice1-rotation="-25" data-slice2-rotation="-25" data-slice1-scale="2" data-slice2-scale="2">
						<div class="sl-slide-inner">
							<div class="bg-img bg-img-1"></div>
							<h3>Facts to know</h3>
							<blockquote><p>1 out of 3 diabetics don't know they have it already!!.</p></blockquote>
						</div>
					</div>
					
					<div class="sl-slide" data-orientation="vertical" data-slice1-rotation="10" data-slice2-rotation="-15" data-slice1-scale="1.5" data-slice2-scale="1.5">
						<div class="sl-slide-inner">
							<div class="bg-img bg-img-2"></div>
							<h3>You can prevent it by: </h3>
							<blockquote>
                                <p><cite>Monotor &/or lower your blood pressure and choestrol.</cite></p>
                               <p> <cite>Manage your weight and BMI</cite></p>
                                <p><cite>30 minutes of activity per day five days per week or 150. Helps lowers the risk of developing type 2 by 58%.</cite></p>
                                <p><cite>Eat a healthy diet. Less fat, more fiber, whole grain, veggies, fruits and lean meat.</cite></p>

							</blockquote>
						</div>
					</div>
					
					<div class="sl-slide" data-orientation="horizontal" data-slice1-rotation="3" data-slice2-rotation="3" data-slice1-scale="2" data-slice2-scale="1">
						<div class="sl-slide-inner">
							<div class="bg-img bg-img-3"></div>
							<h3>Diabetes Complications.</h3>
							<blockquote>
                                <cite>Heart Attack,</cite>
                                <cite>Stroke,</cite>
                                <cite>Peripheral artery disease,</cite>
                                <cite>Diabetic retinopathy,</cite>
                                <cite>Cataracts,</cite>
                                <cite>Glaucoma,</cite>
                                <cite>Diabetic Foot,</cite>
                                <cite>Diabetic Neuropathy,</cite>
                                <cite>Peripheral Neuropathy</cite>
							</blockquote>
						</div>
					</div>
					
					<div class="sl-slide" data-orientation="vertical" data-slice1-rotation="-5" data-slice2-rotation="25" data-slice1-scale="2" data-slice2-scale="1">
						<div class="sl-slide-inner">
							<div class="bg-img bg-img-4"></div>
							<h3>Type 2 Risk Factors</h3>
							<blockquote><p>Family history of diabetes,</p>
                                <cite>Overweight,</cite>
                                <cite>Unhealthy Diet,</cite>
                                <cite>Physical Inactivity,</cite>
                                <cite>Increasing Age,</cite>
                                <cite>High blood pressure,</cite>
                                <cite>Ethnicity,</cite>
                                <cite>Higher then normal blood glucose,</cite>
                                <cite>History of gestional diabetes,</cite>
                                <cite>Poor nutrition during pregenancy</cite>
							</blockquote>
						</div>
					</div>
				</div><!-- /sl-slider -->

				<nav id="nav-dots" class="nav-dots">
					<span class="nav-dot-current"></span>
					<span></span>
					<span></span>
					<span></span>
					<span></span>
				</nav>

			</div><!-- /slider-wrapper -->

        </div>
		<script type="text/javascript" src="js/jquery.ba-cond.min.js"></script>
		<script type="text/javascript" src="js/jquery.slitslider.js"></script>
		<script type="text/javascript">	
			$(function() {
			
				var Page = (function() {

					var $nav = $( '#nav-dots > span' ),
						slitslider = $( '#slider' ).slitslider( {
							onBeforeChange : function( slide, pos ) {

								$nav.removeClass( 'nav-dot-current' );
								$nav.eq( pos ).addClass( 'nav-dot-current' );

							}
						} ),

						init = function() {

							initEvents();
							
						},
						initEvents = function() {

							$nav.each( function( i ) {
							
								$( this ).on( 'click', function( event ) {
									
									var $dot = $( this );
									
									if( !slitslider.isActive() ) {

										$nav.removeClass( 'nav-dot-current' );
										$dot.addClass( 'nav-dot-current' );
									
									}
									
									slitslider.jump( i + 1 );
									return false;
								
								} );
								
							} );

						};

						return { init : init };

				})();

				Page.init();

				/**
				 * Notes: 
				 * 
				 * example how to add items:
				 */

				
				var $items  = $('<div class="sl-slide sl-slide-color-2" data-orientation="horizontal" data-slice1-rotation="-5" data-slice2-rotation="10" data-slice1-scale="2" data-slice2-scale="1"><div class="sl-slide-inner bg-1"><div class="sl-deco" data-icon="t"></div><h2>some text</h2><blockquote><p>bla bla</p><cite>Margi Clarke</cite></blockquote></div></div>');
				
				// call the plugin's add method
				ss.add($items);

			
			
			});
		</script>
		<br />
    <br />
    
      <br />
   

        <div class="h1 t-button col-lg-12" style="text-align:center;">
       <a href="#" >
<span class="label label-primary">Login</span>
</a>
      
    
                 <a href="#">
<span class="label label-primary">Register</span>
</a>
            </div>
        <br />
       
    <div class="clearfix"></div>
      <br />
    
      <br />
</asp:Content>
