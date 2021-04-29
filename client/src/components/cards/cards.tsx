import * as React from 'react';
import Card from '../card/card';
import './cards.css';

interface IProps {
  values: Array<string>;
  onCardSelect(value:string):void;
  selectedItem: string|null;
}

class Cards extends React.Component<IProps> {
  constructor (props: IProps) {
    super(props);
    this.handleCardChange = this.handleCardChange.bind(this);
  }

  public handleCardChange(value: string) {
    this.props.onCardSelect(value)
  }

  public render () {
    const {values} =this.props;

  return (
    <div className="cards">
      {values.map((value) =>
        <Card isSelected={this.props.selectedItem===value} key={value} value={value} selectItem={this.handleCardChange}/>
      )}
    </div>
  );
}}

export default Cards;
