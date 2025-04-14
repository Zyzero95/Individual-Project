import { AnimalInterface } from "@/app/Interfaces/animalinterface";
import AnimalCard from "../Animal Card/animalcard";
import styles from "./query.module.css"
import Pagination from "../Pagination/pagination";
import fetchAllAnimals from "@/app/Actions/fetch";

// Handle query and filter searchParams to render a sorted list. Sends sorted list to Pagination to render proper pagination when the list changes or is default.
export default async function Query({ searchParams}: {searchParams: Promise<{ [key: string]: string | undefined; query: string | undefined; filter: string | undefined}>}) {
    const query = (await searchParams)?.query || '';
    const filter = (await searchParams)?.filter || '';

    const {page = '1', perPage = '6'} =  await searchParams;

    const start = (Number(page) - 1) * Number(perPage);
    const end = start + Number(perPage);

    const data = await fetchAllAnimals();
      if(!data){
        throw new Error("Fetch failed. No animals present.");
      }
      
    let sortyByFilter: AnimalInterface[] = [];

    if(filter !== "default" && sortyByFilter.length === 0){
        sortyByFilter = data;
        sortyByFilter.sort((a, b) => {
            if(filter === "name"){
                const nameA = a.name.toLowerCase();
                const nameB = b.name.toLowerCase();
                if(nameA < nameB) {
                    return -1;
                }
                else if(nameA > nameB){
                    return 1;
                }
                return 0;
            }
            else if(filter === "species"){
                const speciesA = a.species.toLowerCase();
                const speciesB = b.species.toLowerCase();
                if(speciesA < speciesB){
                    return -1;
                }
                else if(speciesA > speciesB){
                    return 1;
                }
                return 0;
            }
            else if(filter === "diet"){
                const dietA = a.foodPreference.toLowerCase();
                const dietB = b.foodPreference.toLowerCase();
                if(dietA < dietB){
                    return -1;
                }
                else if(dietA > dietB){
                    return 1;
                }
                return 0;
            }})} else {
                sortyByFilter = [];
                }

    const searchQuery = Array.isArray(data) ? 
    (sortyByFilter.length === 0 ?
        data.filter((item) => {
            return item.name.toLowerCase().includes(query.toLowerCase());
        }) :
        sortyByFilter.filter((item) => {
            return item.name.toLowerCase().includes(query.toLowerCase());
        })): [];

        const entries = searchQuery.slice(start, end);
        

  return (
    <section className={styles.queryWrapper}> 
        {searchQuery.length === 0 ? <h2 className={styles.queryP}>No animals matched the search term.</h2> : entries.map((item) => <AnimalCard key={item.id} data={item}/>)}
        <section className={styles.queryPagination}>
            <Pagination hasNextPage={end < data.length} hasPrevPage={start > 0} query={query} filter={filter} data={searchQuery}/>
        </section>
    </section>
  )
}
