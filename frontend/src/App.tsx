import React from 'react';
import './App.css';
import Header from './Header';

function Welcome() {
  return <h1>welcome!</h1>;
}

function App() {
  return (
    <div className="App">
      <Header />
      <Welcome />
    </div>
  );
}

export default App;
