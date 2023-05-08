# Music Singer Database

The problems to be solved about singer music database :

Music Database: Design a database where the following information will be kept for a mobile application to be developed to organise and store users' favourite music:
- Mobile application users' username, password, phone number and e-mail
- Name, genre (art music, folk music, ....), duration of the songs
- Name of the singers, music genre (art music, folk music, ....), website address
- Name of the song library (play list), date of creation
- Name and date of birth of composers and lyricists
- Who composed the songs and when, who wrote the lyrics and when, which singers sang which songs and the web address of the singing video, which mobile user the song libraries belong to, which song the user listened to from the mobile application on which date and time

As a solution, the singer database scheme is designed : 

![image](https://user-images.githubusercontent.com/119699844/218271565-986753e5-407a-430a-8d77-bdd11a92e13f.png)

In line with my design, some frequently asked questions by users :

--song names with the subscriber names 'Ege'
select * from Song,Subscriber,SubscriberSong 
where Song.Id=SubscriberSong.SongId 
and Subscriber.Id = SubscriberSong.UserId 
and Username = 'Ege'

--composer of the songs with subscriber name 'Efe'
select ComposerName,Title from Song,Composer,Subscriber,SubscriberSong
where Song.Id=SubscriberSong.SongId
and Subscriber.Id=SubscriberSong.UserId
and Composer.Id=Song.ComposerId
and Username = 'Efe'

--singer names with subscriber name 'Mert'
select SingerName from Subscriber,SubscriberSong,Song,Singer
where Song.Id=SubscriberSong.SongId
and Subscriber.Id=SubscriberSong.UserId
and Singer.Id=Song.SingerId
and Username ='Mert'

--playlist users with PlaylistNames 'Rap List'
select Email from Playlist,SubscriberList,Subscriber
where Playlist.Id=SubscriberList.PlaylistId
and Subscriber.Id=SubscriberList.UserId
and PlaylistName = 'Rap List'

--Playlist songs with PlaylistName 'Pop List'
select Title from Song,SubscriberSong,Subscriber,SubscriberList,Playlist
where Song.Id=SubscriberSong.SongId
and Playlist.Id=SubscriberList.PlaylistId
and Subscriber.Id=SubscriberSong.UserId
and SubscriberList.UserId=Subscriber.Id
and PlaylistName = 'Pop List'

--playlist singers with PlaylistName 'Rap List'
select SingerName from Playlist,SubscriberList,Subscriber,SubscriberSong,Song,Singer
where Playlist.Id=SubscriberList.Id
and Subscriber.Id=SubscriberList.UserId
and Song.Id=SubscriberSong.SongId
and SubscriberSong.UserId=Subscriber.Id
and Singer.Id=Song.SingerId
and PlaylistName = 'Rap List'

--composers of the playlists with PlaylistName 'Rap List'
select ComposerName from Composer,Song,SubscriberSong,Subscriber,SubscriberList,Playlist
where Composer.Id=Song.ComposerId
and Subscriber.Id=SubscriberList.UserId
and Song.Id=SubscriberSong.SongId
and SubscriberSong.UserId=Subscriber.Id
and Playlist.Id=SubscriberList.PlaylistId
and PlaylistName = 'Rap List'
