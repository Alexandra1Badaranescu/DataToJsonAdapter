using System;
using DatabaseReader;
using DataToJsonAdapter;
using Json;

DataBaseReaderL databaseReader = new DataBaseReaderL();
databaseReader.ConnectToDataSource();
JsonAdapter jsonAdapter= new JsonAdapter();
