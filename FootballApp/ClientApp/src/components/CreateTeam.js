import React, { Component, setState } from 'react';

export class CreateTeam extends Component {
    constructor(props) {
        super();
        this.state = {
            teams: [],
            isLoaded: false,
        }
    }

    componentDidMount() {
        fetch('/team')
            .then(res => res.json())
            .then((data) => this.setState({ teams: data, isLoaded: true }))
        }

    render() {
        if (this.state.isLoaded === false) { 
            return <div>No Teams</div>
        } else {
            return <div>{this.state.teams[0].name}</div>
        }
    }
        
}