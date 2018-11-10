import { User } from './../../_models/user';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-member-card-details',
  templateUrl: './member-card-details.component.html',
  styleUrls: ['./member-card-details.component.css']
})
export class MemberCardDetailsComponent implements OnInit {
  @Input() user: User;

  constructor() { }

  ngOnInit() {
  }

}
