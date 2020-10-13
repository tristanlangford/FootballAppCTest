import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Football App</h1>
        <ul>
          <li><a href='/createteam'>Create a Team</a></li>
        </ul>
        <p>To help you get started, we have also set up:</p>
      </div>
    );
  }
}
