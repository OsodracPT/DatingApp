import { AuthGuard } from './_guards/auth.guard';
import {Routes} from '@angular/router';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { HomeComponent } from './home/home.component';
import { MemberListComponent } from './member-list/member-list.component';

export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent},
    { path:   'members', component: MemberListComponent, canActivate: [AuthGuard]},

    { path:   'messages', component: MessagesComponent},

    { path:   'lists', component: ListsComponent},

    { path: '**', redirectTo: 'home', pathMatch: 'full'},
];