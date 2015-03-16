$(document).ready(function() { 
         // create a selector to select the ajax-links for navigation 
         $("body").on("click", ".ajax-link", function() { 
                 // Get the url for the link that the user clicked on  
                 var url = $(this).data("url"); 
                 
                 // Do a get request for that url 
                 $.get(url, function(urlContent) { 
                         // get the body and replace the html data there 
                         $("#mainBody").html(urlContent); 
                     }); 
             }); 
     
 
         // For the about tab links 
         $("body").on("click", ".ajax-tab", function () { 
                 // Get the url for the link that the user clicked on  
                 var url = $(this).data("url"); 
         
 
                 // Do a get request for that url 
                 $.get(url, function (urlContent) { 
                         // get the info and replace the html data there 
                         $(".about-content").html(urlContent); 
                     }); 
             }); 
     
 
     
 
         // the post for the company contact form page 
         $('body').on('submit', '.ajax-form', function (event) { 
                 //preventing the default behavior so the form doesn't try to submit 
                 event.preventDefault(); 
                  
                 $.post($(this).data('posturl'), $(this).serialize(), function (data) { 
                         //update our content area 
                         $('.ajax-form-content').html(data); 
                     }); 
             }); 
     }); 
