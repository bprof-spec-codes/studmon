import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-logout',
  templateUrl: './logout.component.html',
  styleUrls: ['./logout.component.css']
})
export class LogoutComponent implements OnInit{
router: Router
constructor(router: Router){
  this.router = router
}

  ngOnInit(): void {
    localStorage.setItem('studmon-token', '')
    localStorage.setItem('studmon-token-expiration', '')
    localStorage.clear()
    this.router.navigate(['/'])
  }

}
