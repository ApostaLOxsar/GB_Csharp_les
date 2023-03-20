var deletePostLink = document.body.querySelectorAll('yt-icon.ytd-menu-renderer'); 
for (var i = 0; i < deletePostLink. length; i++) 
{
    deletePostLink[i].click(); 
} 
alert (deletePostLink.length + ' posts deleted');
