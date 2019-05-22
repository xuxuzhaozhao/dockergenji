<template>
  <v-layout justify-center>
    <v-flex xs12 sm6 md5 style="margin-left: -200px;">
      <v-container fluid grid-list-md>
        <v-layout row wrap>
          <v-flex
            v-for="card in cards"
            :key="card.title"
            v-bind="{ [`xs${card.flex}`]: true }"
          >
            <v-card>
              <v-img :src="card.src" height="200px" @click="read(card)">
                <v-container fill-height fluid pa-2>
                  <v-layout fill-height>
                    <v-flex xs12 align-end flexbox>
                      <span
                        class="headline white--text"
                        v-text="card.title"
                      ></span>
                    </v-flex>
                  </v-layout>
                </v-container>
              </v-img>

              <v-card-actions>
                <v-btn @click="read(card)">
                  read
                </v-btn>
                <v-spacer></v-spacer>
                <v-btn icon>
                  <v-icon>favorite</v-icon>
                </v-btn>
                <v-btn icon>
                  <v-icon>bookmark</v-icon>
                </v-btn>
                <v-btn icon>
                  <v-icon>share</v-icon>
                </v-btn>
              </v-card-actions>
            </v-card>
          </v-flex>
        </v-layout>
      </v-container>
    </v-flex>
  </v-layout>
</template>

<script>
export default {
  data: () => ({
    cards: [
      {
        title: "Pre-fab homes",
        src: "https://cdn.vuetifyjs.com/images/cards/house.jpg",
        flex: 12
      },
      {
        title: "Favorite road trips",
        src: "https://cdn.vuetifyjs.com/images/cards/road.jpg",
        flex: 12
      },
      {
        title: "Best airlines",
        src: "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
        flex: 12
      },
      {
        title: "Best airlines",
        src: "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
        flex: 12
      },
      {
        title: "Best airlines",
        src: "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
        flex: 12
      },
      {
        title: "Best airlines",
        src: "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
        flex: 12
      },
      {
        title: "Best airlines",
        src: "https://cdn.vuetifyjs.com/images/cards/plane.jpg",
        flex: 12
      }
    ]
  }),

  methods: {
    read(card) {
      alert(card.src);
    }
  }
};
</script>

