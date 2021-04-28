import * as React from 'react';
import Card from '../card/card';
import './cards.css';

interface IProps {
  values: Array<string>;
}

interface IState {
  selectItem: string | null;
}

class Cards extends React.Component<IProps, IState> {
  constructor (props: IProps) {
    super(props);
    this.state = {
      selectItem: null
    };
    this.handleCardChange = this.handleCardChange.bind(this);
  }

  public handleCardChange(value: string) {
    this.setState({
      selectItem: value
    });
  }

  public render () {
    const {values} =this.props;
    const {selectItem: selectedItem} = this.state;

  return (
    <div className="cards">
      {values.map((value) =>
        <Card key={value} value={value} selectItem={this.handleCardChange}/>
      )}
    </div>
  );
}}

export default Cards;
