using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimarisi
{
    class htmlLogger
    {
        public void htmlLogla(Rapor rapor)
        {
            string html = "<!DOCTYPE html><html><head><style>table, th, td {border: 1px solid black;}</style></head><body><h1>Rapor</h1><h2>Hastanın Diyeti</h2>";
            html += "<table style=\"width: 100 % \"><tr>" +
                "<th>ID</th>" +
                "<th>DiyetAdı</th>" +
                " <th>Pazartesi/Kahvaltı</th>" +
                "<th>Pazartesi/Öğlen</th>" +
                "<th>Pazartesi/Akşam</th>" +
                "<th>Salı/Kahvaltı</th>" +
                "<th>Salı/Öğlen</th>" +
                "<th>Salı/Akşam</th>" +
                "<th>Çarşamba/Kahvaltı</th>" +
                "<th>Çarşamba/Öğlen</th>" +
                "<th>Çarşamba/Akşam</th>" +
                "<th>Perşembe/Kahvaltı</th>" +
                "<th>Perşembe/Öğlen</th>" +
                "<th>Perşembe/Akşam</th>" +
                "<th>Cuma/Kahvaltı</th>" +
                "<th>Cuma/Öğlen</th>" +
                "<th>Cuma/Akşam</th>" +
                "<th>Cumartesi/Kahvaltı</th>" +
                "<th>Cumartesi/Öğlen</th>" +
                "<th>Cumartesi/Akşam</th>" +
                "<th>Pazar/Kahvaltı</th>" +
                "<th>Pazar/Öğlen</th>" +
                "<th>Pazar/Akşam</th>";
            html += "<tr><td>"+ rapor.Diyet.ID + "</td>" +
                "<td>" + rapor.Diyet.name + "</td>" +
                "<td>" + rapor.Diyet.Pazartesi.kahvalti + "</td>" +
                "<td>" + rapor.Diyet.Pazartesi.Oglen + "</td>" +
                "<td>" + rapor.Diyet.Pazartesi.Aksam + "</td>" +
                "<td>" + rapor.Diyet.Sali.kahvalti + "</td>" +
                "<td>" + rapor.Diyet.Sali.Oglen + "</td>" +
                "<td>" + rapor.Diyet.Sali.Aksam + "</td>" +
                "<td>" + rapor.Diyet.Carsamba.kahvalti + "</td>" +
                "<td>" + rapor.Diyet.Carsamba.Oglen + "</td>" +
                "<td>" + rapor.Diyet.Carsamba.Aksam + "</td>" +
                "<td>" + rapor.Diyet.Persembe.kahvalti + "</td>" +
                "<td>" + rapor.Diyet.Persembe.Oglen + "</td>" +
                "<td>" + rapor.Diyet.Persembe.Aksam + "</td>" +
                "<td>" + rapor.Diyet.Cuma.kahvalti + "</td>" +
                "<td>" + rapor.Diyet.Cuma.Oglen + "</td>" +
                "<td>" + rapor.Diyet.Cuma.Aksam + "</td>" +
                "<td>" + rapor.Diyet.Cumartesi.kahvalti + "</td>" +
                "<td>" + rapor.Diyet.Cumartesi.Oglen + "</td>" +
                "<td>" + rapor.Diyet.Cumartesi.Aksam + "</td>" +
                "<td>" + rapor.Diyet.Pazar.kahvalti + "</td>" +
                "<td>" + rapor.Diyet.Pazar.Oglen + "</td>" +
                "<td>" + rapor.Diyet.Pazar.Aksam + "</td>" +
                "</tr>";
            html += "</body>" +
                "<h2>Hasta Bilgileri</h2>" +
                "<h3>Hasta : "+rapor.Hasta.AdSoyad+"</h3>" +
                "<h3>TC : "+rapor.Hasta.TC+"</h3>" +
                "<h3>Doğum Tarihi : "+rapor.Hasta.BirthDay+"</h3>" +
                "<h3>Hastalığı : "+rapor.Hasta.HastalikAd+"</h3>" +
                "<h3>Hastanın Tel : "+rapor.Hasta.Tel+"</h3>" +
                "<h3>Hastanın Adresi : "+rapor.Hasta.Adres+"</h3>";



            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save(@"rapor.html");

        }
    }
}
