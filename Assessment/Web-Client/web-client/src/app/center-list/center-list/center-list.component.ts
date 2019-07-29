import { Component, OnInit } from '@angular/core';
import { DataServiceService } from '../../data-service.service';
import { Center } from '../../Models/Center';

@Component({
  selector: 'app-center-list',
  templateUrl: './center-list.component.html',
  styleUrls: ['./center-list.component.scss']
})
export class CenterListComponent implements OnInit {

  centerList :Array<Center>;
  dataToShow: Array<Center>;
  name:string
  constructor(private dataService: DataServiceService) { }

  ngOnInit() {
    this.dataService.getAllCenters().subscribe(data => 
    {
      this.centerList = data;
      this.dataToShow = data;
      console.log(data);
    },error => console.log('Cors Error') );
  }

  filterData(){
    if(this.name.length>0){
    this.dataToShow = this.centerList.filter(x => x.PersonName.includes(this.name));
  }
  else{
    this.dataToShow = this.centerList;
  }
  }

}
