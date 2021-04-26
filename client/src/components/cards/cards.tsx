import * as React from 'react';
import Card from '../card/card';
import './cards.css';

interface IProps {
  values: Array<string>;
}

interface IState {
  selectedItem: string | null;
}

class Cards extends React.Component<IProps, IState> {
  constructor (props: IProps) {
    super(props);
    this.state = {
      selectedItem: null
    };
    this.handleCardChange = this.handleCardChange.bind(this);
  }

  public handleCardChange(value: string) {
    this.setState({
      selectedItem: value
    });
  }

  public render () {
    const {values} =this.props;
    const {selectedItem} = this.state;

  return (
    <div className="cards">
      {values.map((value) =>
        <Card key={value} value={value} selectedItem={this.handleCardChange}/>
      )}
    </div>
  );
}}

export default Cards;
