/* ============================================== dropdown links ============================================== */
if (window.innerWidth  <= 991) {
    let dropdownToggle = $('.dropdown-toggle')
    for (let i = 0; i < dropdownToggle.length; i++) {
        dropdownToggle[i].setAttribute('data-toggle', 'dropdown');
    }
}

let mediaQuery_Max991 = window.matchMedia("(max-width: 991px)") // small screen less than 991

function changeListBehavior_mediaQuery() {

    if (window.innerWidth  <= 991) {
        let dropdownToggle = $('.dropdown-toggle')
        for (let i = 0; i < dropdownToggle.length; i++) {
            dropdownToggle[i].setAttribute('data-toggle', 'dropdown')
        }

        $('header nav #navbarSupportedContent li.dropdown a').click(function (e) { 
            if ($('header nav #navbarSupportedContent li.dropdown').hasClass('show')) {
                if ($(e.delegateTarget.nextElementSibling).hasClass('show')) {
                    setTimeout(() => {
                        $('header nav #navbarSupportedContent li.dropdown .dropdown-menu').removeClass('show');
                        $('header nav #navbarSupportedContent li.dropdown').removeClass('show');
                    }, 10);
                }else{
                    $(e.delegateTarget.nextElementSibling).addClass('show');
                }
            }
        });
        
    }else{
        $('header nav #navbarSupportedContent li a').click(function (e) { 
            $(".dropdown-menu.show").removeProp("style","display");
            $(".dropdown-menu.show").removeClass('show');
        });
        
        let dropdownToggle = $('.dropdown-toggle');
        for (let i = 0; i < dropdownToggle.length; i++) {
            dropdownToggle[i].removeAttribute('data-toggle', 'dropdown');
        }
   }
}
mediaQuery_Max991.addEventListener('change',changeListBehavior_mediaQuery);


/* ============================================== Header owl-carousel ============================================== */

$(document).ready(function(){
    $('header .owl-carousel').owlCarousel({
      animateOut: 'fadeOut',
      loop:true,
      items:1,
      margin:0,
      nav:true,
      autoplay:true,
      autoplayTimeout: 7000,
      slideSpeed: 300,
      paginationSpeed: 400,
      mouseDrag: true,
      navigation: true,
      navText : ['<i class="fas fa-long-arrow-alt-left"></i>','<i class="fas fa-long-arrow-alt-right"></i>'],
      singleItem: true,
  });

  $('.owl-nav button').click(function () { 
      $('.owl-nav button').css({'box-shadow':"none",'outline':"0"});
  });
});

/* ============================================== Pre-loader ============================================== */
$(document).ready(function () {
    setTimeout(() => {
    $('.ltx-theme-loader').addClass('d-none');
        $('body').css('overflow', "auto");
        $('.page-overlay').fadeOut(1000);        
    }, 1000);
});

/* ============================================== Testimonials owl-carousel ============================================== */

$(document).ready(function(){
    $('#testimonials .owl-carousel').owlCarousel({
      loop:true,
      items:1,
      margin:0,
      nav:true,
      autoplay:true,
      autoplayTimeout:8000,
      mouseDrag: true,
      navigation: true,
      navText : ['<i class="fas fa-long-arrow-alt-left"></i>','<i class="fas fa-long-arrow-alt-right"></i>'],

  });
  $('.owl-nav button').click(function () { 
    $('.owl-nav button').css({'box-shadow':"none",'outline':"0"});
});
});

/* ============================================== swipUp ============================================== */

$(window).scroll(function(){
    var myScrollTop = $(window).scrollTop()  ;
   
    if( myScrollTop >= 650)
    {
        $("#swipUp").fadeIn(650)
    }
    else
    {
        $("#swipUp").fadeOut(650)
    }
  })

  $("#swipUp").click(function(){
    $("html , body").animate( {scrollTop : "0"} ,1500 )
  })

/* ============================================== navbar fixed top ============================================== */

$(window).scroll(function(){
    if( $(window).scrollTop() >= 50){
        $('header .navbar').addClass('fixed-top');
    }else{
        $('header .navbar').removeClass('fixed-top');
    }
});
/* ============================================== ## ============================================== */
