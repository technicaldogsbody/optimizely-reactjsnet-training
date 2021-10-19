import React from 'react';
import Header from "./Header";
import Logo from "../../Assets/react.png"

export default {
    title: 'Components/Header',
    component: Header
}

//👇 We create a “template” of how args map to rendering
const Template = (args) => <Header {...args} />;

//👇 Each story then reuses that template
export const Primary = Template.bind({});

Primary.args = {
    logoUrl: Logo,
    strapline: 'I am a strapline'
};
