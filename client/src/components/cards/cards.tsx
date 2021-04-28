import * as React from 'react';
import Card from '../card/card';
import './cards.css';

interface IProps {
  values: Array<string>;
  withoutFocus: boolean;
  onCardSelect(value:string):void;
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
    this.props.onCardSelect(value)
  }

  public render () {
    const {values} =this.props;

  return (
    <div className="cards">
      {values.map((value) =>
        <Card withoutFocus={this.props.withoutFocus} key={value} value={value} selectItem={this.handleCardChange}/>
      )}
    </div>
  );
}}

export default Cards;
